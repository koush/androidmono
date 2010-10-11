namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SeekBar : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SeekBar()
		{
			InitJNI();
		}
		protected SeekBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SeekBar.OnSeekBarChangeListener_))]
		public interface OnSeekBarChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2);
			void onStartTrackingTouch(android.widget.SeekBar arg0);
			void onStopTrackingTouch(android.widget.SeekBar arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SeekBar.OnSeekBarChangeListener))]
		public sealed partial class OnSeekBarChangeListener_ : java.lang.Object, OnSeekBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnSeekBarChangeListener_()
			{
				InitJNI();
			}
			internal OnSeekBarChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onProgressChanged11898;
			 void android.widget.SeekBar.OnSeekBarChangeListener.onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_._onProgressChanged11898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, global::android.widget.SeekBar.OnSeekBarChangeListener_._onProgressChanged11898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onStartTrackingTouch11899;
			 void android.widget.SeekBar.OnSeekBarChangeListener.onStartTrackingTouch(android.widget.SeekBar arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStartTrackingTouch11899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStartTrackingTouch11899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onStopTrackingTouch11900;
			 void android.widget.SeekBar.OnSeekBarChangeListener.onStopTrackingTouch(android.widget.SeekBar arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStopTrackingTouch11900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStopTrackingTouch11900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SeekBar$OnSeekBarChangeListener"));
				global::android.widget.SeekBar.OnSeekBarChangeListener_._onProgressChanged11898 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V");
				global::android.widget.SeekBar.OnSeekBarChangeListener_._onStartTrackingTouch11899 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V");
				global::android.widget.SeekBar.OnSeekBarChangeListener_._onStopTrackingTouch11900 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnSeekBarChangeListener11901;
		public virtual void setOnSeekBarChangeListener(android.widget.SeekBar.OnSeekBarChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar._setOnSeekBarChangeListener11901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.staticClass, global::android.widget.SeekBar._setOnSeekBarChangeListener11901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SeekBar11902;
		public SeekBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar11902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SeekBar11903;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar11903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SeekBar11904;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar11904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SeekBar"));
			global::android.widget.SeekBar._setOnSeekBarChangeListener11901 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V");
			global::android.widget.SeekBar._SeekBar11902 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.SeekBar._SeekBar11903 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SeekBar._SeekBar11904 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
