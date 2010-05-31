namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbsSpinner : android.widget.AdapterView
	{
		internal new static global::java.lang.Class staticClass;
		static AbsSpinner()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AbsSpinner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbsSpinner(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9759;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._onRestoreInstanceState9759, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onRestoreInstanceState9759, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9760;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._onSaveInstanceState9760));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onSaveInstanceState9760));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9761;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._requestLayout9761);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._requestLayout9761);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9762;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._onMeasure9762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onMeasure9762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount9763;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsSpinner._getCount9763);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getCount9763);
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9764;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._generateDefaultLayoutParams9764));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._generateDefaultLayoutParams9764));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9765;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setAdapter9765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter9765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9766;
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setAdapter9766, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter9766, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9767;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._getAdapter9767));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getAdapter9767));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView9768;
		public override global::android.view.View getSelectedView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._getSelectedView9768));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getSelectedView9768));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9769;
		public override void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setSelection9769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection9769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9770;
		public virtual void setSelection(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setSelection9770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection9770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pointToPosition9771;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsSpinner._pointToPosition9771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._pointToPosition9771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner9772;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner9772, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner9773;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner9773, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner9774;
		public AbsSpinner(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner9774, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AbsSpinner.staticClass = @__class;
			global::android.widget.AbsSpinner._onRestoreInstanceState9759 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsSpinner._onSaveInstanceState9760 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsSpinner._requestLayout9761 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V");
			global::android.widget.AbsSpinner._onMeasure9762 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSpinner._getCount9763 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getCount", "()I");
			global::android.widget.AbsSpinner._generateDefaultLayoutParams9764 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsSpinner._setAdapter9765 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsSpinner._setAdapter9766 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V");
			global::android.widget.AbsSpinner._getAdapter9767 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsSpinner._getSelectedView9768 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsSpinner._setSelection9769 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V");
			global::android.widget.AbsSpinner._setSelection9770 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V");
			global::android.widget.AbsSpinner._pointToPosition9771 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsSpinner._AbsSpinner9772 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSpinner._AbsSpinner9773 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsSpinner._AbsSpinner9774 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
