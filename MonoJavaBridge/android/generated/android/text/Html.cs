namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Html : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Html(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Html.ImageGetter_))]
		public partial interface ImageGetter  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Html.ImageGetter))]
		internal sealed partial class ImageGetter_ : java.lang.Object, ImageGetter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ImageGetter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::android.graphics.drawable.Drawable android.text.Html.ImageGetter.getDrawable(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.Html.ImageGetter_.staticClass, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", ref global::android.text.Html.ImageGetter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
			}
			static ImageGetter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Html.ImageGetter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html$ImageGetter"));
			}
		}

		public delegate android.graphics.drawable.Drawable ImageGetterDelegate(java.lang.String arg0);

		internal partial class ImageGetterDelegateWrapper : java.lang.Object, ImageGetter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ImageGetterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ImageGetterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.Html.ImageGetterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.text.Html.ImageGetterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.text.Html.ImageGetterDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Html.ImageGetterDelegateWrapper.staticClass, global::android.text.Html.ImageGetterDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ImageGetterDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Html.ImageGetterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html_ImageGetterDelegateWrapper"));
			}
		}
		internal partial class ImageGetterDelegateWrapper
		{
			private ImageGetterDelegate myDelegate;
			public android.graphics.drawable.Drawable getDrawable(java.lang.String arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator ImageGetterDelegateWrapper(ImageGetterDelegate d)
			{
				global::android.text.Html.ImageGetterDelegateWrapper ret = new global::android.text.Html.ImageGetterDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Html.TagHandler_))]
		public partial interface TagHandler  : global::MonoJavaBridge.IJavaObject 
		{
			void handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Html.TagHandler))]
		internal sealed partial class TagHandler_ : java.lang.Object, TagHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TagHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.text.Html.TagHandler.handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Html.TagHandler_.staticClass, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", ref global::android.text.Html.TagHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			static TagHandler_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Html.TagHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html$TagHandler"));
			}
		}

		public delegate void TagHandlerDelegate(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3);

		internal partial class TagHandlerDelegateWrapper : java.lang.Object, TagHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected TagHandlerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public TagHandlerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.Html.TagHandlerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.text.Html.TagHandlerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.text.Html.TagHandlerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Html.TagHandlerDelegateWrapper.staticClass, global::android.text.Html.TagHandlerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static TagHandlerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Html.TagHandlerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html_TagHandlerDelegateWrapper"));
			}
		}
		internal partial class TagHandlerDelegateWrapper
		{
			private TagHandlerDelegate myDelegate;
			public void handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3)
			{
				myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator TagHandlerDelegateWrapper(TagHandlerDelegate d)
			{
				global::android.text.Html.TagHandlerDelegateWrapper ret = new global::android.text.Html.TagHandlerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.Spanned fromHtml(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Html._m0.native == global::System.IntPtr.Zero)
				global::android.text.Html._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;)Landroid/text/Spanned;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Spanned>(@__env.CallStaticObjectMethod(android.text.Html.staticClass, global::android.text.Html._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Spanned;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.text.Spanned fromHtml(java.lang.String arg0, android.text.Html.ImageGetter arg1, android.text.Html.TagHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Html._m1.native == global::System.IntPtr.Zero)
				global::android.text.Html._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;Landroid/text/Html$ImageGetter;Landroid/text/Html$TagHandler;)Landroid/text/Spanned;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Spanned>(@__env.CallStaticObjectMethod(android.text.Html.staticClass, global::android.text.Html._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Spanned;
		}
		public static android.text.Spanned fromHtml(java.lang.String arg0, global::android.text.Html.ImageGetterDelegate arg1, global::android.text.Html.TagHandlerDelegate arg2)
		{
			return fromHtml(arg0, (global::android.text.Html.ImageGetterDelegateWrapper)arg1, (global::android.text.Html.TagHandlerDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String toHtml(android.text.Spanned arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Html._m2.native == global::System.IntPtr.Zero)
				global::android.text.Html._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.Html.staticClass, "toHtml", "(Landroid/text/Spanned;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.Html.staticClass, global::android.text.Html._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static Html()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Html.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html"));
		}
	}
}
