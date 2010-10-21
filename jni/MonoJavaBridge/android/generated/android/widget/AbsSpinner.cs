namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsSpinner_))]
	public abstract partial class AbsSpinner : android.widget.AdapterView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSpinner()
		{
			InitJNI();
		}
		protected AbsSpinner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16493;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._onRestoreInstanceState16493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onRestoreInstanceState16493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16494;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._onSaveInstanceState16494)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onSaveInstanceState16494)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout16495;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._requestLayout16495);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._requestLayout16495);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16496;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._onMeasure16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onMeasure16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCount16497;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSpinner._getCount16497);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getCount16497);
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams16498;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._generateDefaultLayoutParams16498)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._generateDefaultLayoutParams16498)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16499;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setAdapter16499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter16499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16500;
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setAdapter16500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter16500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter16501;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._getAdapter16501)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getAdapter16501)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView16502;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._getSelectedView16502)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getSelectedView16502)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16503;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setSelection16503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection16503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16504;
		public virtual void setSelection(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setSelection16504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection16504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition16505;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSpinner._pointToPosition16505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._pointToPosition16505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner16506;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner16506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner16507;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner16507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner16508;
		public AbsSpinner(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner16508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSpinner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSpinner"));
			global::android.widget.AbsSpinner._onRestoreInstanceState16493 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsSpinner._onSaveInstanceState16494 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsSpinner._requestLayout16495 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V");
			global::android.widget.AbsSpinner._onMeasure16496 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSpinner._getCount16497 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "getCount", "()I");
			global::android.widget.AbsSpinner._generateDefaultLayoutParams16498 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsSpinner._setAdapter16499 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsSpinner._setAdapter16500 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V");
			global::android.widget.AbsSpinner._getAdapter16501 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsSpinner._getSelectedView16502 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsSpinner._setSelection16503 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V");
			global::android.widget.AbsSpinner._setSelection16504 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V");
			global::android.widget.AbsSpinner._pointToPosition16505 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsSpinner._AbsSpinner16506 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSpinner._AbsSpinner16507 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsSpinner._AbsSpinner16508 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsSpinner))]
	public sealed partial class AbsSpinner_ : android.widget.AbsSpinner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSpinner_()
		{
			InitJNI();
		}
		internal AbsSpinner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSpinner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSpinner"));
		}
	}
}
