namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DynamicDrawableSpan : android.text.style.ReplacementSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DynamicDrawableSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.DynamicDrawableSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DynamicDrawableSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize6951; 
		public override int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DynamicDrawableSpan)) 
				return @__env.CallIntMethod(this, _getSize6951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.DynamicDrawableSpan.staticClass, _getSize6951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable6952; 
		public abstract android.graphics.drawable.Drawable getDrawable(); 
		internal static global::net.sf.jni4net.jni.MethodId _draw6953; 
		public override void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DynamicDrawableSpan)) 
				@__env.CallVoidMethod(this, _draw6953, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.DynamicDrawableSpan.staticClass, _draw6953, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalAlignment6954; 
		public virtual int getVerticalAlignment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DynamicDrawableSpan)) 
				return @__env.CallIntMethod(this, _getVerticalAlignment6954); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.DynamicDrawableSpan.staticClass, _getVerticalAlignment6954); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicDrawableSpan6955; 
		public DynamicDrawableSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, _DynamicDrawableSpan6955, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicDrawableSpan6956; 
		protected DynamicDrawableSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, _DynamicDrawableSpan6956, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
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
			global::android.text.style.DynamicDrawableSpan._getSize6951 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMetricsInt;)I"); 
			global::android.text.style.DynamicDrawableSpan._getDrawable6952 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.text.style.DynamicDrawableSpan._draw6953 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)V"); 
			global::android.text.style.DynamicDrawableSpan._getVerticalAlignment6954 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "getVerticalAlignment", "()I"); 
			global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan6955 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "()V"); 
			global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan6956 = @__env.GetMethodID(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
