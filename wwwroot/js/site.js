/* =============================================
   CATALOGO - LIVE ACTION SYSTEM
   Efectos de chispas y luces dinámicas
   ============================================= */

document.addEventListener('DOMContentLoaded', () => {
    /* Añadir dentro de document.addEventListener('DOMContentLoaded', ...) */

    const navLinks = document.querySelectorAll('.nav-link');

    navLinks.forEach((link, index) => {
        // Crea un efecto de cascada: se encienden uno por uno
        setTimeout(() => {
            link.style.color = "#ffd700";
            link.style.textShadow = "0 0 8px #ffd700";
        }, 200 * index);
    });

    /* Añadir esto dentro del DOMContentLoaded en site.js */

    const forceGlowText = () => {
        // Seleccionamos todos los elementos de texto comunes
        const texts = document.querySelectorAll('h1, h2, h3, h4, h5, p, span, a, label, .detail-value');

        texts.forEach(el => {
            // Si el texto está oscuro, lo forzamos a dorado/blanco
            el.style.color = "var(--accent-primary, #ffd700)";
            el.style.textShadow = "2px 2px 4px rgba(0,0,0,0.9), 0 0 10px rgba(255,215,0,0.5)";
        });
    };

    // Ejecutar al inicio
    forceGlowText();


    // 1. GENERADOR DE CHISPAS (POLVO DE ORO DINÁMICO)
    // Esto crea partículas que flotan por toda la pantalla
    const createSpark = () => {
        const spark = document.createElement('div');
        spark.classList.add('gold-spark');

        const size = Math.random() * 4 + 2 + 'px';
        const destinationX = (Math.random() - 0.5) * 300;
        const destinationY = -Math.random() * 500;

        Object.assign(spark.style, {
            position: 'fixed',
            left: Math.random() * window.innerWidth + 'px',
            top: window.innerHeight + 'px',
            width: size,
            height: size,
            backgroundColor: 'var(--accent-primary, #ffd700)',
            borderRadius: '50%',
            boxShadow: '0 0 10px var(--accent-primary)',
            pointerEvents: 'none',
            zIndex: '9999',
            opacity: Math.random(),
            transition: `transform ${Math.random() * 2 + 3}s linear, opacity 2s`
        });

        document.body.appendChild(spark);

        // Animación de subida
        setTimeout(() => {
            spark.style.transform = `translate(${destinationX}px, ${destinationY}px)`;
            spark.style.opacity = '0';
        }, 50);

        // Limpieza
        setTimeout(() => spark.remove(), 5000);
    };

    // Crear chispas continuamente
    setInterval(createSpark, 150);

    // 2. LUZ DE SEGUIMIENTO (SPOTLIGHT)
    // Crea un resplandor dorado que sigue al cursor
    const spotlight = document.createElement('div');
    Object.assign(spotlight.style, {
        position: 'fixed',
        width: '400px',
        height: '400px',
        borderRadius: '50%',
        background: 'radial-gradient(circle, rgba(255,215,0,0.1) 0%, transparent 70%)',
        pointerEvents: 'none',
        zIndex: '-1',
        transform: 'translate(-50%, -50%)',
        transition: 'width 0.3s, height 0.3s'
    });
    document.body.appendChild(spotlight);

    document.addEventListener('mousemove', (e) => {
        spotlight.style.left = e.clientX + 'px';
        spotlight.style.top = e.clientY + 'px';
    });

    // 3. EFECTO DE IMPACTO EN TARJETAS
    const cards = document.querySelectorAll('.game-card');
    cards.forEach(card => {
        card.addEventListener('mouseenter', () => {
            // Relucir letras fuerte
            const title = card.querySelector('.game-card-title');
            if (title) {
                title.style.color = '#fff';
                title.style.textShadow = '0 0 20px #ffd700, 0 0 40px #ffae00';
            }
        });

        card.addEventListener('mouseleave', () => {
            const title = card.querySelector('.game-card-title');
            if (title) {
                title.style.color = '';
                title.style.textShadow = '';
            }

        });
    });
    .privacy - container {
        max - width: 800px;
        margin: 50px auto;
        padding: 30px;
        background: rgba(255, 255, 255, 0.03);
        border: 1px solid var(--accent - color);
        border - radius: 15px;
        box - shadow: 0 0 20px rgba(130, 87, 229, 0.2);
    }

.privacy - section {
        margin - bottom: 30px;
        padding: 15px;
        border - left: 3px solid var(--neon - cyan);
        background: rgba(0, 247, 255, 0.02);
    }

.text - accent {
        color: var(--accent - color);
        text - transform: uppercase;
        font - weight: bold;
    }

.text - neon - cyan {
        color: var(--neon - cyan);
        font - family: 'Orbitron', sans - serif;
        letter - spacing: 2px;
    }

/* Efecto de parpadeo para el "Encriptado" */
.blink {
        animation: blinker 1.5s linear infinite;
    }

    @keyframes blinker {
        50 % { opacity: 0; }
    }

.glitch - title - small {
        font - family: 'Orbitron', sans - serif;
        color: #fff;
        text - shadow: 2px 2px var(--accent - color);
    }
});