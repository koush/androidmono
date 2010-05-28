namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DynamicDrawableSpan : android.text.style.ReplacementSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DynamicDrawableSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.DynamicDrawableSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DynamicDrawableSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize7322; 
		public override int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DynamicDrawableSpan)) 
				return @__env.CallIntMethod(this, global::android.text.style.DynamicDrawableSpan._getSize7322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._getSize7322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable7323; 
		public abstract global::android.graphics.drawable.Drawable getDrawable(); 
		internal static global::net.sf.jni4net.jni.MethodId _draw7324; 
		public override void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DynamicDrawableSpan)) 
				@__env.CallVoidMethod(this, global::android.text.style.DynamicDrawableSpan._draw7324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._draw7324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalAlignment7325; 
		public virtual int getVerticalAlignment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DynamicDrawableSpan)) 
				return @__env.CallIntMethod(this, global::android.text.style.DynamicDrawableSpan._getVerticalAlignment7325); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._getVerticalAlignment7325); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicDrawableSpan7326; 
		public DynamicDrawableSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan7326, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicDrawableSpan7327; 
		protected DynamicDrawableSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan7327, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		public static int ALIGN_BOTTOM
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int ALIGN_BASELINE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.DynamicDrawableSpan.staticClass = @__class; 
			global::android.text.style.DynamicDrawableSpan._getSize7322 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMetricsInt;)I"); 
			global::android.text.style.DynamicDrawableSpan._getDrawable7323 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.text.style.DynamicDrawableSpan._draw7324 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)V"); 
			global::android.text.style.DynamicDrawableSpan._getVerticalAlignment7325 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "getVerticalAlignment", "()I"); 
			global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan7326 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "()V"); 
			global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan7327 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
