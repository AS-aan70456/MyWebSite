document.querySelector('button').onclick = myClick;

function myClick() {
    let a = document.querySelector('.nav-scrol').value;

    window.location.href = '/Home/Search/' + a;
}