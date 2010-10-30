namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsSpinner_))]
	public abstract partial class AbsSpinner : android.widget.AdapterView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsSpinner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.AbsSpinner._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.AbsSpinner._m1) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V", ref global::android.widget.AbsSpinner._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V", ref global::android.widget.AbsSpinner._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSpinner.staticClass, "getCount", "()I", ref global::android.widget.AbsSpinner._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsSpinner._m5) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.AbsSpinner._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V", ref global::android.widget.AbsSpinner._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.AbsSpinner._m8) as android.widget.Adapter;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::android.view.View getSelectedView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;", ref global::android.widget.AbsSpinner._m9) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V", ref global::android.widget.AbsSpinner._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setSelection(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V", ref global::android.widget.AbsSpinner._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int pointToPosition(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I", ref global::android.widget.AbsSpinner._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSpinner._m13.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSpinner._m13 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSpinner._m14.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSpinner._m14 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public AbsSpinner(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSpinner._m15.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSpinner._m15 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbsSpinner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSpinner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSpinner"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsSpinner))]
	internal sealed partial class AbsSpinner_ : android.widget.AbsSpinner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbsSpinner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbsSpinner_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSpinner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSpinner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
