namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SpanWatcher : NoCopySpan
	{ 
		void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3); 
		void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3); 
		void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5); 
	} 

	public partial class SpanWatcher_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SpanWatcher.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SpanWatcher : java.lang.Object, SpanWatcher
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SpanWatcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__SpanWatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.__SpanWatcher(@__env); 
			} 
		} 
		internal __SpanWatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanAdded6882; 
		 void android.text.SpanWatcher.onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.__SpanWatcher._onSpanAdded6882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__SpanWatcher.staticClass, global::android.text.__SpanWatcher._onSpanAdded6882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanRemoved6883; 
		 void android.text.SpanWatcher.onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.__SpanWatcher._onSpanRemoved6883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__SpanWatcher.staticClass, global::android.text.__SpanWatcher._onSpanRemoved6883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanChanged6884; 
		 void android.text.SpanWatcher.onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.__SpanWatcher._onSpanChanged6884, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__SpanWatcher.staticClass, global::android.text.__SpanWatcher._onSpanChanged6884, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.__SpanWatcher.staticClass = @__class; 
			global::android.text.__SpanWatcher._onSpanAdded6882 = @__env.GetMethodID(global::android.text.__SpanWatcher.staticClass, "android.text.SpanWatcher.onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V"); 
			global::android.text.__SpanWatcher._onSpanRemoved6883 = @__env.GetMethodID(global::android.text.__SpanWatcher.staticClass, "android.text.SpanWatcher.onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V"); 
			global::android.text.__SpanWatcher._onSpanChanged6884 = @__env.GetMethodID(global::android.text.__SpanWatcher.staticClass, "android.text.SpanWatcher.onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V"); 
		} 
	} 
} 
