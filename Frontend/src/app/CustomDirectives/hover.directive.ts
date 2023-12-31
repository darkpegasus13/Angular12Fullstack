import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHoverDirective], .appHoverDirective'
})
export class HoverDirective {

  constructor(private el: ElementRef) { }

  @HostListener('mouseenter') onMouseEnter() {
    this.highlight('blue');
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.highlight('');
  }

  private highlight(color: string) {
    this.el.nativeElement.style.borderColor = color;
  }

}
