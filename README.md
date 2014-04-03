boardgamegeekapi.net
====================

Thanks for your interest in the project.  Please feel free to fork and submit pull requests for things you feel should be in the project.

Currently my goal is to implement the models for all of the API requests and have integration testing for all for them.  I would do unit testing but I currently can't figure out how to mock the RestSharp object to fake the response as to not rely on the call to BGG.

## Getting Started ##
    var client = new BGGAPI.Client();
	var collectionRequest = new BGGAPI.Collection.Request 
		{
			UserName = "tysonjhayes",
			Rated = true,
			Stats = true
		};
	var collection = client.GetCollection(collectionRequest);

