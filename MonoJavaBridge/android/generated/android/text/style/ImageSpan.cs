namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageSpan : android.text.style.DynamicDrawableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::android.graphics.drawable.Drawable getDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.ImageSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.text.style.ImageSpan._m0) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String Source
		{
			get
			{
				return getSource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.style.ImageSpan.staticClass, "getSource", "()Ljava/lang/String;", ref global::android.text.style.ImageSpan._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ImageSpan(android.graphics.Bitmap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m2.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m2 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ImageSpan(android.graphics.Bitmap arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m3.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m3 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m4.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m4 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m5.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m5 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ImageSpan(android.graphics.drawable.Drawable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m6.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m6 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ImageSpan(android.graphics.drawable.Drawable arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m7.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m7 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m8.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m8 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m9.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m9 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m10.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m10 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m11.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m11 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public ImageSpan(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m12.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m12 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public ImageSpan(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ImageSpan._m13.native == global::System.IntPtr.Zero)
				global::android.text.style.ImageSpan._m13 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ImageSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ImageSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ImageSpan"));
		}
	}
}
