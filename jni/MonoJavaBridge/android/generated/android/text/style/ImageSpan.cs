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
		internal static global::MonoJavaBridge.MethodId _getDrawable8812;
		public override global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan._getDrawable8812)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._getDrawable8812)) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String Source
		{
			get
			{
				return getSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSource8813;
		public virtual global::java.lang.String getSource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan._getSource8813)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._getSource8813)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8814;
		public ImageSpan(android.graphics.Bitmap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8815;
		public ImageSpan(android.graphics.Bitmap arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8816;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8817;
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8818;
		public ImageSpan(android.graphics.drawable.Drawable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8819;
		public ImageSpan(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8820;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8821;
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8822;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8823;
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8824;
		public ImageSpan(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSpan8825;
		public ImageSpan(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ImageSpan.staticClass, global::android.text.style.ImageSpan._ImageSpan8825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ImageSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ImageSpan"));
			global::android.text.style.ImageSpan._getDrawable8812 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.text.style.ImageSpan._getSource8813 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "getSource", "()Ljava/lang/String;");
			global::android.text.style.ImageSpan._ImageSpan8814 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.text.style.ImageSpan._ImageSpan8815 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;I)V");
			global::android.text.style.ImageSpan._ImageSpan8816 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V");
			global::android.text.style.ImageSpan._ImageSpan8817 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V");
			global::android.text.style.ImageSpan._ImageSpan8818 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.text.style.ImageSpan._ImageSpan8819 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
			global::android.text.style.ImageSpan._ImageSpan8820 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V");
			global::android.text.style.ImageSpan._ImageSpan8821 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V");
			global::android.text.style.ImageSpan._ImageSpan8822 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.text.style.ImageSpan._ImageSpan8823 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V");
			global::android.text.style.ImageSpan._ImageSpan8824 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.text.style.ImageSpan._ImageSpan8825 = @__env.GetMethodIDNoThrow(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
		}
	}
}
