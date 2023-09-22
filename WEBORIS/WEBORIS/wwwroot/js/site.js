const buttonDescription = document.querySelector(".button-description")
const productDescription = document.querySelector(".product-description")
const productReview = document.querySelectorAll(".product-review")
const buttonReview = document.querySelector(".button-reviews")
buttonDescription.addEventListener("click", () => {
    buttonDescription.classList.add("pink-color")
    buttonReview.classList.remove("pink-color")
    productDescription.classList.remove("display-none")
    for(let i = 0; i < productReview.length; i++) {
        productReview[i].classList.add("display-none")
    }
    console.log("fds")
})
buttonReview.addEventListener("click", () => {
    buttonReview.classList.add("pink-color")
    buttonDescription.classList.remove("pink-color")
    for (let i = 0; i < productReview.length; i++) {
        productReview[i].classList.remove("display-none")
    }
    productDescription.classList.add("display-none")
})