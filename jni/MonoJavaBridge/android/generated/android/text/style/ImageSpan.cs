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
		internal static global::MonoJavaBridge.MethodId _getDrawable13494;
		public override global::android.graphics.drawable.Drawable getDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan._getDrawable13494)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._getDrawable13494)) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String Source
		{
			get
			{
				return getSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSource13495;
		public virtual global::java.lang.String getSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan._getSource13495)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._getSource13495)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13496;
		public ImageSpan(android.graphics.Bitmap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13497;
		public ImageSpan(android.graphics.Bitmap arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13498;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13499;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13500;
		public ImageSpan(android.graphics.drawable.Drawable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13501;
		public ImageSpan(android.graphics.drawable.Drawable arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13502;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13503;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13504;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13505;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13506;
		public ImageSpan(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan13507;
		public ImageSpan(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan13507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ImageSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ImageSpan"));
			global::android.text.style.ImageSpan._getDrawable13494 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.text.style.ImageSpan._getSource13495 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "getSource", "()Ljava/lang/String;");
			global::android.text.style.ImageSpan._ImageSpan13496 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.text.style.ImageSpan._ImageSpan13497 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;I)V");
			global::android.text.style.ImageSpan._ImageSpan13498 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V");
			global::android.text.style.ImageSpan._ImageSpan13499 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V");
			global::android.text.style.ImageSpan._ImageSpan13500 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.text.style.ImageSpan._ImageSpan13501 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
			global::android.text.style.ImageSpan._ImageSpan13502 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V");
			global::android.text.style.ImageSpan._ImageSpan13503 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V");
			global::android.text.style.ImageSpan._ImageSpan13504 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.text.style.ImageSpan._ImageSpan13505 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V");
			global::android.text.style.ImageSpan._ImageSpan13506 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.text.style.ImageSpan._ImageSpan13507 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
		}
	}
}
