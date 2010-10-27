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
		public partial interface OnSeekBarChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2);
			void onStartTrackingTouch(android.widget.SeekBar arg0);
			void onStopTrackingTouch(android.widget.SeekBar arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SeekBar.OnSeekBarChangeListener))]
		internal sealed partial class OnSeekBarChangeListener_ : java.lang.Object, OnSeekBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnSeekBarChangeListener_()
			{
				InitJNI();
			}
			internal OnSeekBarChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onProgressChanged17736;
			void android.widget.SeekBar.OnSeekBarChangeListener.onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_._onProgressChanged17736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, global::android.widget.SeekBar.OnSeekBarChangeListener_._onProgressChanged17736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onStartTrackingTouch17737;
			void android.widget.SeekBar.OnSeekBarChangeListener.onStartTrackingTouch(android.widget.SeekBar arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStartTrackingTouch17737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStartTrackingTouch17737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onStopTrackingTouch17738;
			void android.widget.SeekBar.OnSeekBarChangeListener.onStopTrackingTouch(android.widget.SeekBar arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStopTrackingTouch17738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, global::android.widget.SeekBar.OnSeekBarChangeListener_._onStopTrackingTouch17738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SeekBar$OnSeekBarChangeListener"));
				global::android.widget.SeekBar.OnSeekBarChangeListener_._onProgressChanged17736 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V");
				global::android.widget.SeekBar.OnSeekBarChangeListener_._onStartTrackingTouch17737 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V");
				global::android.widget.SeekBar.OnSeekBarChangeListener_._onStopTrackingTouch17738 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnSeekBarChangeListener17739;
		public virtual void setOnSeekBarChangeListener(android.widget.SeekBar.OnSeekBarChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SeekBar._setOnSeekBarChangeListener17739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SeekBar.staticClass, global::android.widget.SeekBar._setOnSeekBarChangeListener17739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SeekBar17740;
		public SeekBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar17740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SeekBar17741;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar17741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SeekBar17742;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar17742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SeekBar"));
			global::android.widget.SeekBar._setOnSeekBarChangeListener17739 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V");
			global::android.widget.SeekBar._SeekBar17740 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.SeekBar._SeekBar17741 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SeekBar._SeekBar17742 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
