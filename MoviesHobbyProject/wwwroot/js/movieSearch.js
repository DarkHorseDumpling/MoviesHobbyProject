    $(document).ready(() => {
        $('#searchForm').on('submit', (e) => {
            let searchText = $('#searchText').val();
            e.preventDefault();
            getMovies(searchText);
        });
    });
    
    function getMovies(searchText) {
        const searchTerm = searchText;
        const apiKey = '078923f64c5714a90fb9477198305522';
        axios.get(`https://api.themoviedb.org/3/search/movie?api_key=${apiKey}&query=${searchTerm}`)
            .then((response) => {
                console.log(response);
                let movies = response.data.results;
                
                let output = '';
                $.each(movies, (index, movie) => {
                    let poster_post = "https://image.tmdb.org/t/p/w185" + movie.poster_path;
                    output += `
                        <div class="col-md-3">
                            <div class="well text-center">
                                <img src="${poster_post}">
                                <h5>${movie.original_title}</h5>
                                <a onclick="movieSelected('${movie.id}')" class="btn btn-primary" href="#">Movie Details</a>
                            </div>
                        </div>
                    `;
                });

                $('#movies').html(output);
            })
            .catch((err) => {
                console.log(err);
            });
    }

    function movieSelected(id) {
        sessionStorage.setItem('movieId', id);
        window.location = '../Views/Movie/MovieInfo.cshtml';
        return false;
    }


    function getMovie() {
        let movieId = sessionStorage.getItem('movieId');

    const apiKey = '078923f64c5714a90fb9477198305522';
    axios.get(`https://api.themoviedb.org/3/movie/${movieId}?api_key=${apiKey}`)
        .then((response) => {
            console.log(response);
            let movie = response.data;
            let poster_post = "https://image.tmdb.org/t/p/w185" + movie.poster_path;
            let output = `
                <div class="row">
                    <div class="col-md-4">
                        <img src="${poster_post}" class="thumbnail">
                    </div>
                    <div class="col-md-8">
                        <h2>${movie.original_title}</h2>
                        <h5>${movie.tagline}</h5>
                        <ul class="list-group">
                            <li class="list-group-item"><strong>Runtime: </strong>${movie.runtime} minutes</li>
                            <li class="list-group-item"><strong>Genre: </strong>${movie.genres[0].name}</li>
                            <li class="list-group-item"><strong>Released: </strong>${movie.release_date}</li>
                            <li class="list-group-item"><strong>Rating: </strong>${movie.vote_average}</li>
                            <li class="list-group-item"><strong>Budget: </strong>$${(movie.budget).toLocaleString("en")}</li>
                            <li class="list-group-item"><strong>Revenue: </strong>$${(movie.revenue).toLocaleString("en")}</li>
                    </div>
                </div>
                <div class="row">
                    <div class="well">
                        <h3>Plot</h3>
                        ${movie.overview}
                        <hr>
                        <a href="http://imdb.com/title/${movie.imdb_id}" target="_blank" class="btn btn-primary">View IMDB</a>
                        <a href="index.html" class="btn btn-default">Go Back To Search</a>
                    </div>
                </div>
            `;

            $('#movie').html(output);
        })
        .catch((err) => {
            console.log(err);
        });
    }
