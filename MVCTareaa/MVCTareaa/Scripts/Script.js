$(document).ready(function () {

    // AGREGANDO CLASE ACTIVE AL PRIMER ENLACE ====================
    $('.category_list .category_item[category="all"]').addClass('ct_item-active');

    // FILTRANDO Noticias  ============================================

    $('.category_item').click(function () {
        var catNews = $(this).attr('category');
        console.log(catNews);

        // AGREGANDO CLASE ACTIVE AL ENLACE SELECCIONADO
        $('.category_item').removeClass('ct_item-active');
        $(this).addClass('ct_item-active');

        // OCULTANDO Noticias =========================
        $('.news-item').css('transform', 'scale(0)');
        function hideNews() {
            $('.news-item').hide();
        } setTimeout(hideNews, 400);

        // MOSTRANDO Noticias =========================
        function showNews() {
            $('.news-item[category="' + catNews + '"]').show();
            $('.news-item[category="' + catNews + '"]').css('transform', 'scale(1)');
        } setTimeout(showNews, 600);
    });

    // MOSTRANDO TODOS LOS Noticias =======================

    $('.category_item[category="all"]').click(function () {
        function showAll() {
            $('.news-item').show();
            $('.news-item').css('transform', 'scale(1)');
        } setTimeout(showAll, 600);
    });
    $('.category_item').click(function () {
        var catMovie = $(this).attr('category');
        console.log(catMovie);
        // OCULTANDO Peliculas =========================
        $('.movie-item').css('transform', 'scale(0)');
        function hideMovie() {
            $('.movie-item').hide();
        } setTimeout(hideMovie, 400);

        // MOSTRANDO Peliculas =========================
        function showMovie() {
            $('.movie-item[category="' + catMovie + '"]').show();
            $('.movie-item[category="' + catMovie + '"]').css('transform', 'scale(1)');
        } setTimeout(showMovie, 600);

        // MOSTRANDO TODOS LOS Peliculas =======================

        $('.category_item[category="all"]').click(function () {
            function showAll() {
                $('.movie-item').show();
                $('.movie-item').css('transform', 'scale(1)');
            } setTimeout(showAll, 600);
        });
    });
});