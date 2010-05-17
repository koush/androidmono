namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ImageSpan : android.text.style.DynamicDrawableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ImageSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.ImageSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.ImageSpan(@__env); 
			} 
		} 
		protected ImageSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable6969; 
		public override android.graphics.drawable.Drawable getDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ImageSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable6969)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.ImageSpan.staticClass, _getDrawable6969)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSource6970; 
		public virtual java.lang.String getSource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ImageSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSource6970)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.ImageSpan.staticClass, _getSource6970)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6971; 
		public ImageSpan(android.graphics.Bitmap arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6971, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6972; 
		public ImageSpan(android.graphics.Bitmap arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6972, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6973; 
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6973, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6974; 
		public ImageSpan(android.content.Context arg0, android.graphics.Bitmap arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6974, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6975; 
		public ImageSpan(android.graphics.drawable.Drawable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6975, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6976; 
		public ImageSpan(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6976, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6977; 
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6977, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6978; 
		public ImageSpan(android.graphics.drawable.Drawable arg0, java.lang.String arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6978, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6979; 
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6979, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6980; 
		public ImageSpan(android.content.Context arg0, android.net.Uri arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6980, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6981; 
		public ImageSpan(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6981, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSpan6982; 
		public ImageSpan(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ImageSpan.staticClass, _ImageSpan6982, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.ImageSpan.staticClass = @__class; 
			global::android.text.style.ImageSpan._getDrawable6969 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.text.style.ImageSpan._getSource6970 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "getSource", "()Ljava/lang/String;"); 
			global::android.text.style.ImageSpan._ImageSpan6971 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V"); 
			global::android.text.style.ImageSpan._ImageSpan6972 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;I)V"); 
			global::android.text.style.ImageSpan._ImageSpan6973 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V"); 
			global::android.text.style.ImageSpan._ImageSpan6974 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V"); 
			global::android.text.style.ImageSpan._ImageSpan6975 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.text.style.ImageSpan._ImageSpan6976 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V"); 
			global::android.text.style.ImageSpan._ImageSpan6977 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V"); 
			global::android.text.style.ImageSpan._ImageSpan6978 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V"); 
			global::android.text.style.ImageSpan._ImageSpan6979 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V"); 
			global::android.text.style.ImageSpan._ImageSpan6980 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V"); 
			global::android.text.style.ImageSpan._ImageSpan6981 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.text.style.ImageSpan._ImageSpan6982 = @__env.GetMethodID(global::android.text.style.ImageSpan.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
		} 
	} 
} 
