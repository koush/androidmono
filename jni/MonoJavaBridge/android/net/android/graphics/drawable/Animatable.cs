namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Animatable 
	{ 
		void start(); 
		void stop(); 
		bool isRunning(); 
	} 

	public partial class Animatable_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Animatable.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Animatable : java.lang.Object, Animatable
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Animatable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.__Animatable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.__Animatable(@__env); 
			} 
		} 
		internal __Animatable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start3432; 
		 void android.graphics.drawable.Animatable.start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.__Animatable)) 
				@__env.CallVoidMethod(this, _start3432); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.__Animatable.staticClass, _start3432); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop3433; 
		 void android.graphics.drawable.Animatable.stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.__Animatable)) 
				@__env.CallVoidMethod(this, _stop3433); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.__Animatable.staticClass, _stop3433); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRunning3434; 
		 bool android.graphics.drawable.Animatable.isRunning() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.__Animatable)) 
				return @__env.CallBooleanMethod(this, _isRunning3434); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.__Animatable.staticClass, _isRunning3434); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.__Animatable.staticClass = @__class; 
			global::android.graphics.drawable.__Animatable._start3432 = @__env.GetMethodID(global::android.graphics.drawable.__Animatable.staticClass, "android.graphics.drawable.Animatable.start", "()V"); 
			global::android.graphics.drawable.__Animatable._stop3433 = @__env.GetMethodID(global::android.graphics.drawable.__Animatable.staticClass, "android.graphics.drawable.Animatable.stop", "()V"); 
			global::android.graphics.drawable.__Animatable._isRunning3434 = @__env.GetMethodID(global::android.graphics.drawable.__Animatable.staticClass, "android.graphics.drawable.Animatable.isRunning", "()Z"); 
		} 
	} 
} 
