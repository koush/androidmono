namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SeekBar : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal OnSeekBarChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.SeekBar.OnSeekBarChangeListener.onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V", ref global::android.widget.SeekBar.OnSeekBarChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.widget.SeekBar.OnSeekBarChangeListener.onStartTrackingTouch(android.widget.SeekBar arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V", ref global::android.widget.SeekBar.OnSeekBarChangeListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.widget.SeekBar.OnSeekBarChangeListener.onStopTrackingTouch(android.widget.SeekBar arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V", ref global::android.widget.SeekBar.OnSeekBarChangeListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnSeekBarChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SeekBar.OnSeekBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SeekBar$OnSeekBarChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setOnSeekBarChangeListener(android.widget.SeekBar.OnSeekBarChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SeekBar.staticClass, "setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V", ref global::android.widget.SeekBar._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SeekBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SeekBar._m1.native == global::System.IntPtr.Zero)
				global::android.widget.SeekBar._m1 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SeekBar._m2.native == global::System.IntPtr.Zero)
				global::android.widget.SeekBar._m2 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SeekBar._m3.native == global::System.IntPtr.Zero)
				global::android.widget.SeekBar._m3 = @__env.GetMethodIDNoThrow(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SeekBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SeekBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SeekBar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
