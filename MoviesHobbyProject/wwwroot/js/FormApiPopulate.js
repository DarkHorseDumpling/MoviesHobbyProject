
function ApiSearch() {
    let searchText = $('#MovieName').val();
    getMovies(searchText);
}
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
                        <div class="col-md-2">
                            <div class="well text-center">
                                <img class="img-fluid" src="${poster_post}">
                                <h6>${movie.original_title}</h6>
                                <a onclick="movieSelected('${movie.id}'); getMovie();" class="btn btn-primary">Select Movie</a>
                            </div>
                        </div>
                    `;
                return index < 5;
            });

            $('#movies').html(output);
        })
        .catch((err) => {
            console.log(err);
        });
}

function movieSelected(id) {
    sessionStorage.setItem('movieId', id);
    $('#showHideResults').hide();
    $('#movies').hide();
    $('#searchPrompt').hide();
    return false;
}


function getMovie() {
    let movieId = sessionStorage.getItem('movieId');
    const apiKey = '078923f64c5714a90fb9477198305522';
    axios.get(`https://api.themoviedb.org/3/movie/${movieId}?api_key=${apiKey}`)
        .then((response) => {
            console.log(response);
            $('#APIReferenceID').val(movieId);


            $('#movie').html(output);
        })
        .catch((err) => {
            console.log(err);
        });
}
