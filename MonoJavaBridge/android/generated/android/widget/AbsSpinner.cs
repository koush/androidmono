namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsSpinner_))]
	public abstract partial class AbsSpinner : android.widget.AdapterView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsSpinner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16585;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.AbsSpinner._onRestoreInstanceState16585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16586;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.AbsSpinner._onSaveInstanceState16586) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout16587;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V", ref global::android.widget.AbsSpinner._requestLayout16587);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16588;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V", ref global::android.widget.AbsSpinner._onMeasure16588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCount16589;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSpinner.staticClass, "getCount", "()I", ref global::android.widget.AbsSpinner._getCount16589);
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams16590;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsSpinner._generateDefaultLayoutParams16590) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16591;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.AbsSpinner._setAdapter16591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16592;
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V", ref global::android.widget.AbsSpinner._setAdapter16592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter16593;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.AbsSpinner._getAdapter16593) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView16594;
		public override global::android.view.View getSelectedView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;", ref global::android.widget.AbsSpinner._getSelectedView16594) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16595;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V", ref global::android.widget.AbsSpinner._setSelection16595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16596;
		public virtual void setSelection(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V", ref global::android.widget.AbsSpinner._setSelection16596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition16597;
		public virtual int pointToPosition(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I", ref global::android.widget.AbsSpinner._pointToPosition16597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner16598;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSpinner._AbsSpinner16598.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSpinner._AbsSpinner16598 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner16598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner16599;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSpinner._AbsSpinner16599.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSpinner._AbsSpinner16599 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner16599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner16600;
		public AbsSpinner(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsSpinner._AbsSpinner16600.native == global::System.IntPtr.Zero)
				global::android.widget.AbsSpinner._AbsSpinner16600 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner16600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
