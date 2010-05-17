namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DrawableMarginSpan : java.lang.Object, LeadingMarginSpan, LineHeightSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static DrawableMarginSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.DrawableMarginSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.DrawableMarginSpan(@__env); 
			} 
		} 
		protected DrawableMarginSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeadingMargin6946; 
		public virtual int getLeadingMargin(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DrawableMarginSpan)) 
				return @__env.CallIntMethod(this, _getLeadingMargin6946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.DrawableMarginSpan.staticClass, _getLeadingMargin6946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawLeadingMargin6947; 
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DrawableMarginSpan)) 
				@__env.CallVoidMethod(this, _drawLeadingMargin6947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.DrawableMarginSpan.staticClass, _drawLeadingMargin6947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _chooseHeight6948; 
		public virtual void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.DrawableMarginSpan)) 
				@__env.CallVoidMethod(this, _chooseHeight6948, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.DrawableMarginSpan.staticClass, _chooseHeight6948, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DrawableMarginSpan6949; 
		public DrawableMarginSpan(android.graphics.drawable.Drawable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.DrawableMarginSpan.staticClass, _DrawableMarginSpan6949, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DrawableMarginSpan6950; 
		public DrawableMarginSpan(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.DrawableMarginSpan.staticClass, _DrawableMarginSpan6950, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.DrawableMarginSpan.staticClass = @__class; 
			global::android.text.style.DrawableMarginSpan._getLeadingMargin6946 = @__env.GetMethodID(global::android.text.style.DrawableMarginSpan.staticClass, "getLeadingMargin", "(Z)I"); 
			global::android.text.style.DrawableMarginSpan._drawLeadingMargin6947 = @__env.GetMethodID(global::android.text.style.DrawableMarginSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V"); 
			global::android.text.style.DrawableMarginSpan._chooseHeight6948 = @__env.GetMethodID(global::android.text.style.DrawableMarginSpan.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V"); 
			global::android.text.style.DrawableMarginSpan._DrawableMarginSpan6949 = @__env.GetMethodID(global::android.text.style.DrawableMarginSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.text.style.DrawableMarginSpan._DrawableMarginSpan6950 = @__env.GetMethodID(global::android.text.style.DrawableMarginSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V"); 
		} 
	} 
} 
