using Foundation;
using System;
using System.Linq;
using UIKit;
using HamiltonSoundboard.Core;
using System.Collections.Generic;

namespace HamiltonSoundboard
{
    public partial class ClipTableViewController : UITableViewController
    {
        ClipsDataService dataService = new ClipsDataService();
        UISearchController searchController;

        public ClipTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            var clips = new List<Clip>();

            //Creates an instance of a custom View Controller that holds the results
            var searchResultsController = new SearchResultsViewController(this);

            //Creates a search controller updater
            var searchUpdater = new SearchResultsUpdator();
            searchUpdater.UpdateSearchResults += searchResultsController.Search;

            //add the search controller
            searchController = new UISearchController(searchResultsController)
            {
                SearchResultsUpdater = searchUpdater
            };
            
            //format the search bar
            searchController.SearchBar.SizeToFit();
            searchController.SearchBar.SearchBarStyle = UISearchBarStyle.Minimal;
            searchController.SearchBar.Placeholder = "Enter a search query";

            //the search bar is contained in the navigation bar, so it should be visible
            searchController.HidesNavigationBarDuringPresentation = false;

            //Ensure the searchResultsController is presented in the current View Controller 
            DefinesPresentationContext = true;

            //Set the search bar in the navigation bar
            NavigationItem.TitleView = searchController.SearchBar;

            clips = dataService.GetAllClips();

            var dataSource = new ClipDataSource(clips, this);
            this.NavigationItem.Title = "Hamilton Menu";
            TableView.TableHeaderView = searchController.SearchBar;
            TableView.Source = dataSource;
        }
    }
}