  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
 
      // Navbar scroll effect
      window.addEventListener('scroll', () => {
          document.querySelector('.navbar').classList.toggle('scrolled', window.scrollY > 80);
      });
      // Fade in sections
      const sections = document.querySelectorAll('.fade-section');
      const observer = new IntersectionObserver((entries) => {
          entries.forEach(entry => {
              if (entry.isIntersecting) {
                  entry.target.classList.add('visible');
              }
          });
      }, { threshold: 0.15 });
      sections.forEach(section => observer.observe(section));
 