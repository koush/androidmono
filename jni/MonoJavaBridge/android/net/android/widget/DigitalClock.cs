namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DigitalClock : android.widget.TextView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DigitalClock() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.DigitalClock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.DigitalClock(@__env); 
			} 
		} 
		protected DigitalClock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10116; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DigitalClock)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow10116); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DigitalClock.staticClass, _onAttachedToWindow10116); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10117; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DigitalClock)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow10117); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DigitalClock.staticClass, _onDetachedFromWindow10117); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DigitalClock10118; 
		public DigitalClock(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DigitalClock.staticClass, _DigitalClock10118, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DigitalClock10119; 
		public DigitalClock(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DigitalClock.staticClass, _DigitalClock10119, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.DigitalClock.staticClass = @__class; 
			global::android.widget.DigitalClock._onAttachedToWindow10116 = @__env.GetMethodID(global::android.widget.DigitalClock.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.DigitalClock._onDetachedFromWindow10117 = @__env.GetMethodID(global::android.widget.DigitalClock.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.DigitalClock._DigitalClock10118 = @__env.GetMethodID(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.DigitalClock._DigitalClock10119 = @__env.GetMethodID(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
