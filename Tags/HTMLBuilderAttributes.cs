using System;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;

namespace Tags
{
    public static class HTMLBuilderAttributes
    {
        public static HTMLBuilder<X, Y> Accept<X, Y>(this HTMLBuilder<X, Y> builder, string fileType)
            where X : Input
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAccept(fileType);
            return builder;
        }

        public static HTMLBuilder<X, Y> AcceptCharset<X, Y>(this HTMLBuilder<X, Y> builder, Charset charset)
            where X : Form
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAcceptCharset(charset);
            return builder;
        }

        public static HTMLBuilder<X, Y> Action<X, Y>(this HTMLBuilder<X, Y> builder, string action)
            where X : Form
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAction(action);
            return builder;
        }

        public static HTMLBuilder<X, Y> Alt<X, Y>(this HTMLBuilder<X, Y> builder, string alt)
            where X : Tag, SupportAltAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAlt(alt);
            return builder;
        }

        public static HTMLBuilder<X, Y> Autocomplete<X, Y>(this HTMLBuilder<X, Y> builder, bool autocomplete)
            where X : Tag, SupportAutocompleteAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAutocomplete(autocomplete);
            return builder;
        }

        public static HTMLBuilder<X, Y> Autofocus<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportAutofocusAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAutofocus();
            return builder;
        }

        public static HTMLBuilder<X, Y> Autoplay<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportAutoplayAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddAutoplay();
            return builder;
        }

        public static HTMLBuilder<X, Y> Charset<X, Y>(this HTMLBuilder<X, Y> builder, Charset charset)
            where X : Tag, SupportCharsetAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCharset(charset);
            return builder;
        }

        public static HTMLBuilder<X, Y> Checked<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Input
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddChecked();
            return builder;
        }

        public static HTMLBuilder<X, Y> Cite<X, Y>(this HTMLBuilder<X, Y> builder, string cite)
            where X : Tag, SupportCiteAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCite(cite);
            return builder;
        }

        public static HTMLBuilder<X, Y> Cols<X, Y>(this HTMLBuilder<X, Y> builder, int cols)
            where X : Textarea
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCols(cols);
            return builder;
        }

        public static HTMLBuilder<X, Y> Colspan<X, Y>(this HTMLBuilder<X, Y> builder, int colspan)
            where X : Tag, SupportColspanAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddColspan(colspan);
            return builder;
        }

        public static HTMLBuilder<X, Y> Controls<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportControlsAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddControls();
            return builder;
        }

        public static HTMLBuilder<X, Y> Coords<X, Y>(this HTMLBuilder<X, Y> builder, string coords)
            where X : Area
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCoords(coords);
            return builder;
        }

        public static HTMLBuilder<X, Y> Crossorigin<X, Y>(this HTMLBuilder<X, Y> builder, Crossorigin crossorigin)
            where X : Link
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCrossorigin(crossorigin);
            return builder;
        }

        public static HTMLBuilder<X, Y> Data<X, Y>(this HTMLBuilder<X, Y> builder, string data)
            where X : HTMLTags.Object
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddData(data);
            return builder;
        }

        public static HTMLBuilder<X, Y> Datetime<X, Y>(this HTMLBuilder<X, Y> builder, DateTime datetime)
            where X : Tag, SupportDatetimeAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddDatetime(datetime);
            return builder;
        }

        public static HTMLBuilder<X, Y> Default<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Track
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddDefault();
            return builder;
        }

        public static HTMLBuilder<X, Y> Disabled<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportDisabledAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddDisabled();
            return builder;
        }

        public static HTMLBuilder<X, Y> Download<X, Y>(this HTMLBuilder<X, Y> builder, string filename = "")
            where X : Tag, SupportDownloadAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddDownload(filename);
            return builder;
        }

        public static HTMLBuilder<X, Y> Execution<X, Y>(this HTMLBuilder<X, Y> builder, Execution execution)
            where X : ExternalScript
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddExecution(execution);
            return builder;
        }

        public static HTMLBuilder<X, Y> For<X, Y>(this HTMLBuilder<X, Y> builder, string id)
            where X : Tag, SupportForAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddFor(id);
            return builder;
        }

        public static HTMLBuilder<X, Y> Form<X, Y>(this HTMLBuilder<X, Y> builder, string id)
            where X : Tag, SupportFormAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddForm(id);
            return builder;
        }

        public static HTMLBuilder<X, Y> Headers<X, Y>(this HTMLBuilder<X, Y> builder, string headers)
            where X : Tag, SupportHeadersAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHeaders(headers);
            return builder;
        }

        public static HTMLBuilder<X, Y> Height<X, Y>(this HTMLBuilder<X, Y> builder, int height)
            where X : Tag, SupportHeightAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHeight(height);
            return builder;
        }

        public static HTMLBuilder<X, Y> High<X, Y>(this HTMLBuilder<X, Y> builder, double value)
            where X : Meter
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHigh(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Href<X, Y>(this HTMLBuilder<X, Y> builder, string href)
            where X : Area
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHref(href);
            return builder;
        }

        public static HTMLBuilder<X, Y> HttpEquiv<X, Y>(this HTMLBuilder<X, Y> builder, HttpEquiv httpEquiv, string content)
            where X : Meta
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHttpEquiv(httpEquiv, content);
            return builder;
        }

        public static HTMLBuilder<X, Y> Kind<X, Y>(this HTMLBuilder<X, Y> builder, Kind kind, string srclang = null)
            where X : Track
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddKind(kind, srclang);
            return builder;
        }

        public static HTMLBuilder<X, Y> Label<X, Y>(this HTMLBuilder<X, Y> builder, string label)
            where X : Tag, SupportLabelAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddLabel(label);
            return builder;
        }

        public static HTMLBuilder<X, Y> List<X, Y>(this HTMLBuilder<X, Y> builder, string datalistId)
            where X : Input
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddList(datalistId);
            return builder;
        }

        public static HTMLBuilder<X, Y> Loop<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportLoopAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddLoop();
            return builder;
        }

        public static HTMLBuilder<X, Y> Low<X, Y>(this HTMLBuilder<X, Y> builder, double value)
            where X : Meter
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddLow(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Max<X, Y>(this HTMLBuilder<X, Y> builder, double value)
            where X : Meter
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMax(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> MaxLength<X, Y>(this HTMLBuilder<X, Y> builder, int value)
            where X : Tag, SupportMaxLengthAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMaxLength(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Media<X, Y>(this HTMLBuilder<X, Y> builder, string media)
            where X : Tag, SupportMediaQueryAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMedia(media);
            return builder;
        }

        public static HTMLBuilder<X, Y> Method<X, Y>(this HTMLBuilder<X, Y> builder, Method method, EncType? enctype = null)
            where X : Form
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMethod(method, enctype);
            return builder;
        }

        public static HTMLBuilder<X, Y> Min<X, Y>(this HTMLBuilder<X, Y> builder, double value)
            where X : Meter
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMin(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Multiple<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportMultipleAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMultiple();
            return builder;
        }

        public static HTMLBuilder<X, Y> Muted<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportMutedAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMuted();
            return builder;
        }

        public static HTMLBuilder<X, Y> Name<X, Y>(this HTMLBuilder<X, Y> builder, string name)
            where X : Tag, SupportNameAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddName(name);
            return builder;
        }

        public static HTMLBuilder<X, Y> Name<X, Y>(this HTMLBuilder<X, Y> builder, Name name, string content)
            where X : Meta
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddName(name, content);
            return builder;
        }

        public static HTMLBuilder<X, Y> NoValidate<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Form
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddNoValidate();
            return builder;
        }

        public static HTMLBuilder<X, Y> Open<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Details
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddOpen();
            return builder;
        }

        public static HTMLBuilder<X, Y> Optimum<X, Y>(this HTMLBuilder<X, Y> builder, double value)
            where X : Meter
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddOptimum(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Pattern<X, Y>(this HTMLBuilder<X, Y> builder, string pattern)
            where X : Input
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddPattern(pattern);
            return builder;
        }

        public static HTMLBuilder<X, Y> Placeholder<X, Y>(this HTMLBuilder<X, Y> builder, string placeholder)
            where X : Tag, SupportPlaceholderAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddPlaceholder(placeholder);
            return builder;
        }

        public static HTMLBuilder<X, Y> Poster<X, Y>(this HTMLBuilder<X, Y> builder, string url)
            where X : Video
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddPoster(url);
            return builder;
        }

        public static HTMLBuilder<X, Y> Preload<X, Y>(this HTMLBuilder<X, Y> builder, Preload preload)
            where X : Tag, SupportPreloadAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddPreload(preload);
            return builder;
        }

        public static HTMLBuilder<X, Y> Readonly<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportReadonlyAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddReadonly();
            return builder;
        }
        
        public static HTMLBuilder<X, Y> Rel<X, Y>(this HTMLBuilder<X, Y> builder, Rel rel)
            where X : Tag, SupportRelAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRel(rel);
            return builder;
        }

        public static HTMLBuilder<X, Y> Rel<X, Y>(this HTMLBuilder<X, Y> builder, LinkRel rel)
            where X : Link
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRel(rel);
            return builder;
        }

        public static HTMLBuilder<X, Y> Required<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag, SupportRequiredAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRequired();
            return builder;
        }

        public static HTMLBuilder<X, Y> Reversed<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Ol
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddReversed();
            return builder;
        }

        public static HTMLBuilder<X, Y> Rows<X, Y>(this HTMLBuilder<X, Y> builder, int rows)
            where X : Textarea
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRows(rows);
            return builder;
        }

        public static HTMLBuilder<X, Y> Rowspan<X, Y>(this HTMLBuilder<X, Y> builder, int rowspan)
            where X : Tag, SupportRowspanAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRowspan(rowspan);
            return builder;
        }        

        public static HTMLBuilder<X, Y> Sandbox<X, Y>(this HTMLBuilder<X, Y> builder, params Sandbox[] sandbox)
            where X : Iframe
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSandbox(sandbox);
            return builder;
        }

        public static HTMLBuilder<X, Y> Scope<X, Y>(this HTMLBuilder<X, Y> builder, Scope scope)
            where X : Th
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddScope(scope);
            return builder;
        }

        public static HTMLBuilder<X, Y> Selected<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Option
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSelected();
            return builder;
        }

        public static HTMLBuilder<X, Y> Shape<X, Y>(this HTMLBuilder<X, Y> builder, Shape shape)
            where X : Area
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddShape(shape);
            return builder;
        }

        public static HTMLBuilder<X, Y> Size<X, Y>(this HTMLBuilder<X, Y> builder, int size)
            where X : Tag, SupportSizeAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSize(size);
            return builder;
        }

        public static HTMLBuilder<X, Y> Span<X, Y>(this HTMLBuilder<X, Y> builder, int span)
            where X : Tag, SupportSpanAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSpan(span);
            return builder;
        }

        public static HTMLBuilder<X, Y> Src<X, Y>(this HTMLBuilder<X, Y> builder, string src)
            where X : Tag, SupportSrcAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSrc(src);
            return builder;
        }

        public static HTMLBuilder<X, Y> Srcset<X, Y>(this HTMLBuilder<X, Y> builder, string src)
            where X : Tag, SupportSrcsetAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSrcset(src);
            return builder;
        }

        public static HTMLBuilder<X, Y> Srcdoc<X, Y>(this HTMLBuilder<X, Y> builder, string srcdoc)
            where X : Iframe
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSrcdoc(srcdoc);
            return builder;
        }

        public static HTMLBuilder<X, Y> Start<X, Y>(this HTMLBuilder<X, Y> builder, int start)
            where X : Ol
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddStart(start);
            return builder;
        }

        public static HTMLBuilder<X, Y> Step<X, Y>(this HTMLBuilder<X, Y> builder, int step)
            where X : Input
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddStep(step);
            return builder;
        }

        public static HTMLBuilder<X, Y> Target<X, Y>(this HTMLBuilder<X, Y> builder, Target target)
            where X : Tag, SupportTargetAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddTarget(target);
            return builder;
        }

        public static HTMLBuilder<X, Y> Type<X, Y>(this HTMLBuilder<X, Y> builder, string type)
            where X : Tag, SupportMIMETypeAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddType(type);
            return builder;
        }

        public static HTMLBuilder<X, Y> Usemap<X, Y>(this HTMLBuilder<X, Y> builder, string id)
            where X : Tag, SupportUsemapAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddUsemap(id);
            return builder;
        }

        public static HTMLBuilder<X, Y> Value<X, Y>(this HTMLBuilder<X, Y> builder, int value)
            where X : Tag, SupportNumberValueAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddValue(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Value<X, Y>(this HTMLBuilder<X, Y> builder, string value)
            where X : Tag, SupportStringValueAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddValue(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Width<X, Y>(this HTMLBuilder<X, Y> builder, int width)
            where X : Tag, SupportWidthAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddWidth(width);
            return builder;
        }

        public static HTMLBuilder<X, Y> Wrap<X, Y>(this HTMLBuilder<X, Y> builder, Wrap wrap)
            where X : Textarea
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddWrap(wrap);
            return builder;
        }
    }
}