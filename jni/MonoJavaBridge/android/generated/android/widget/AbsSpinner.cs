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
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState11354;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._onRestoreInstanceState11354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onRestoreInstanceState11354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState11355;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._onSaveInstanceState11355)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onSaveInstanceState11355)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout11356;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._requestLayout11356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._requestLayout11356);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11357;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._onMeasure11357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onMeasure11357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCount11358;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSpinner._getCount11358);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getCount11358);
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams11359;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._generateDefaultLayoutParams11359)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._generateDefaultLayoutParams11359)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11360;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setAdapter11360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter11360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11361;
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setAdapter11361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter11361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter11362;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._getAdapter11362)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getAdapter11362)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView11363;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner._getSelectedView11363)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getSelectedView11363)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11364;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setSelection11364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection11364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11365;
		public virtual void setSelection(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner._setSelection11365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection11365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition11366;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsSpinner._pointToPosition11366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._pointToPosition11366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner11367;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner11367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner11368;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner11368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSpinner11369;
		public AbsSpinner(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner11369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsSpinner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsSpinner"));
			global::android.widget.AbsSpinner._onRestoreInstanceState11354 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsSpinner._onSaveInstanceState11355 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsSpinner._requestLayout11356 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V");
			global::android.widget.AbsSpinner._onMeasure11357 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSpinner._getCount11358 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "getCount", "()I");
			global::android.widget.AbsSpinner._generateDefaultLayoutParams11359 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsSpinner._setAdapter11360 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsSpinner._setAdapter11361 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V");
			global::android.widget.AbsSpinner._getAdapter11362 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsSpinner._getSelectedView11363 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsSpinner._setSelection11364 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V");
			global::android.widget.AbsSpinner._setSelection11365 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V");
			global::android.widget.AbsSpinner._pointToPosition11366 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsSpinner._AbsSpinner11367 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSpinner._AbsSpinner11368 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsSpinner._AbsSpinner11369 = @__env.GetMethodIDNoThrow(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V");
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
