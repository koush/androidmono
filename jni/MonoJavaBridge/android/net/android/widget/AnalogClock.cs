namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AnalogClock : android.view.View
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AnalogClock() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AnalogClock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.AnalogClock(@__env); 
			} 
		} 
		protected AnalogClock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow9856; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AnalogClock)) 
				@__env.CallVoidMethod(this, global::android.widget.AnalogClock._onAttachedToWindow9856); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onAttachedToWindow9856); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9857; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AnalogClock)) 
				@__env.CallVoidMethod(this, global::android.widget.AnalogClock._onDetachedFromWindow9857); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onDetachedFromWindow9857); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9858; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AnalogClock)) 
				@__env.CallVoidMethod(this, global::android.widget.AnalogClock._onSizeChanged9858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onSizeChanged9858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9859; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AnalogClock)) 
				@__env.CallVoidMethod(this, global::android.widget.AnalogClock._onDraw9859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onDraw9859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9860; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AnalogClock)) 
				@__env.CallVoidMethod(this, global::android.widget.AnalogClock._onMeasure9860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onMeasure9860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnalogClock9861; 
		public AnalogClock(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock9861, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnalogClock9862; 
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock9862, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnalogClock9863; 
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock9863, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.AnalogClock.staticClass = @__class; 
			global::android.widget.AnalogClock._onAttachedToWindow9856 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.AnalogClock._onDetachedFromWindow9857 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.AnalogClock._onSizeChanged9858 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.AnalogClock._onDraw9859 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.AnalogClock._onMeasure9860 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.AnalogClock._AnalogClock9861 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.AnalogClock._AnalogClock9862 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AnalogClock._AnalogClock9863 = @__env.GetMethodID(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
