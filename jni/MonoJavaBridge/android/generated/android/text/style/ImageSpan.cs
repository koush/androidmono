namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageSpan : android.text.style.DynamicDrawableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ImageSpan()
		{
			InitJNI();
		}
		protected ImageSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable13432;
		public override global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan._getDrawable13432)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._getDrawable13432)) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String Source
		{
			get
			{
				return getSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSource13433;
		public virtual global::java.lang.String getSource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan._getSource13433)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._getSource13433)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13434;
		public ImageSpan(android.graphics.Bitmap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13435;
		public ImageSpan(android.graphics.Bitmap arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13436;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13437;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13438;
		public ImageSpan(android.graphics.drawable.Drawable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13439;
		public ImageSpan(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13440;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13441;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13442;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13443;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13444;
		public ImageSpan(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13445;
		public ImageSpan(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ImageSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ImageSpan"));
			global::android.text.style.ImageSpan._getDrawable13432 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.text.style.ImageSpan._getSource13433 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "getSource", "()Ljava/lang/String;");
			global::android.text.style.ImageSpan._ImageSpan13434 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.text.style.ImageSpan._ImageSpan13435 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;I)V");
			global::android.text.style.ImageSpan._ImageSpan13436 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V");
			global::android.text.style.ImageSpan._ImageSpan13437 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V");
			global::android.text.style.ImageSpan._ImageSpan13438 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.text.style.ImageSpan._ImageSpan13439 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
			global::android.text.style.ImageSpan._ImageSpan13440 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V");
			global::android.text.style.ImageSpan._ImageSpan13441 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V");
			global::android.text.style.ImageSpan._ImageSpan13442 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.text.style.ImageSpan._ImageSpan13443 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V");
			global::android.text.style.ImageSpan._ImageSpan13444 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.text.style.ImageSpan._ImageSpan13445 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
		}
	}
}
