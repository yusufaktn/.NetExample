// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Film Koleksiyonu JavaScript Kodları

// Sayfa yüklendiğinde animasyonları başlat
document.addEventListener('DOMContentLoaded', function () {
    const cards = document.querySelectorAll('.card');
    cards.forEach((card, index) => {
        card.style.animationDelay = `${index * 0.1}s`;
    });
});

// Yıldız derecelendirmesi için interaktif özellik
function initRatingStars() {
    const ratingContainers = document.querySelectorAll('.rating');
    ratingContainers.forEach(container => {
        const stars = container.querySelectorAll('.bi-star, .bi-star-fill');
        stars.forEach((star, index) => {
            star.addEventListener('mouseover', () => {
                for (let i = 0; i <= index; i++) {
                    stars[i].classList.remove('bi-star');
                    stars[i].classList.add('bi-star-fill');
                }
            });

            star.addEventListener('mouseout', () => {
                stars.forEach((s, i) => {
                    const rating = parseInt(container.dataset.rating || 0);
                    if (i >= rating) {
                        s.classList.remove('bi-star-fill');
                        s.classList.add('bi-star');
                    }
                });
            });
        });
    });
}
