namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.PerformanceTestCase_Intermediates_))]
	public interface PerformanceTestCase_Intermediates  : global::MonoJavaBridge.IJavaObject 
	{
		void setInternalIterations(int arg0);
		void startTiming(bool arg0);
		void addIntermediate(java.lang.String arg0);
		void addIntermediate(java.lang.String arg0, long arg1);
		void finishTiming(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.PerformanceTestCase_Intermediates))]
	public sealed partial class PerformanceTestCase_Intermediates_ : java.lang.Object, PerformanceTestCase_Intermediates
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PerformanceTestCase_Intermediates_()
		{
			InitJNI();
		}
		internal PerformanceTestCase_Intermediates_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setInternalIterations7732;
		 void android.test.PerformanceTestCase_Intermediates.setInternalIterations(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_._setInternalIterations7732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_.staticClass, global::android.test.PerformanceTestCase_Intermediates_._setInternalIterations7732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTiming7733;
		 void android.test.PerformanceTestCase_Intermediates.startTiming(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_._startTiming7733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_.staticClass, global::android.test.PerformanceTestCase_Intermediates_._startTiming7733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIntermediate7734;
		 void android.test.PerformanceTestCase_Intermediates.addIntermediate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_._addIntermediate7734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_.staticClass, global::android.test.PerformanceTestCase_Intermediates_._addIntermediate7734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIntermediate7735;
		 void android.test.PerformanceTestCase_Intermediates.addIntermediate(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_._addIntermediate7735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_.staticClass, global::android.test.PerformanceTestCase_Intermediates_._addIntermediate7735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _finishTiming7736;
		 void android.test.PerformanceTestCase_Intermediates.finishTiming(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_._finishTiming7736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.PerformanceTestCase_Intermediates_.staticClass, global::android.test.PerformanceTestCase_Intermediates_._finishTiming7736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.PerformanceTestCase_Intermediates_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/PerformanceTestCase_Intermediates"));
			global::android.test.PerformanceTestCase_Intermediates_._setInternalIterations7732 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_Intermediates_.staticClass, "setInternalIterations", "(I)V");
			global::android.test.PerformanceTestCase_Intermediates_._startTiming7733 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_Intermediates_.staticClass, "startTiming", "(Z)V");
			global::android.test.PerformanceTestCase_Intermediates_._addIntermediate7734 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_Intermediates_.staticClass, "addIntermediate", "(Ljava/lang/String;)V");
			global::android.test.PerformanceTestCase_Intermediates_._addIntermediate7735 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_Intermediates_.staticClass, "addIntermediate", "(Ljava/lang/String;J)V");
			global::android.test.PerformanceTestCase_Intermediates_._finishTiming7736 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_Intermediates_.staticClass, "finishTiming", "(Z)V");
		}
	}
}
