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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10456;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._onRestoreInstanceState10456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onRestoreInstanceState10456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10457;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._onSaveInstanceState10457));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onSaveInstanceState10457));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10458;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._requestLayout10458);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._requestLayout10458);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10459;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._onMeasure10459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._onMeasure10459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10460;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsSpinner._getCount10460);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getCount10460);
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10461;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._generateDefaultLayoutParams10461));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._generateDefaultLayoutParams10461));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10462;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setAdapter10462, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter10462, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10463;
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setAdapter10463, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setAdapter10463, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10464;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._getAdapter10464));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getAdapter10464));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView10465;
		public override global::android.view.View getSelectedView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsSpinner._getSelectedView10465));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._getSelectedView10465));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10466;
		public override void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setSelection10466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection10466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10467;
		public virtual void setSelection(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsSpinner._setSelection10467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._setSelection10467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pointToPosition10468;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsSpinner._pointToPosition10468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._pointToPosition10468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner10469;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner10469, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner10470;
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner10470, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner10471;
		public AbsSpinner(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsSpinner.staticClass, global::android.widget.AbsSpinner._AbsSpinner10471, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AbsSpinner.staticClass = @__class;
			global::android.widget.AbsSpinner._onRestoreInstanceState10456 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsSpinner._onSaveInstanceState10457 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsSpinner._requestLayout10458 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V");
			global::android.widget.AbsSpinner._onMeasure10459 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsSpinner._getCount10460 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getCount", "()I");
			global::android.widget.AbsSpinner._generateDefaultLayoutParams10461 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsSpinner._setAdapter10462 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsSpinner._setAdapter10463 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V");
			global::android.widget.AbsSpinner._getAdapter10464 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsSpinner._getSelectedView10465 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsSpinner._setSelection10466 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V");
			global::android.widget.AbsSpinner._setSelection10467 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V");
			global::android.widget.AbsSpinner._pointToPosition10468 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsSpinner._AbsSpinner10469 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsSpinner._AbsSpinner10470 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsSpinner._AbsSpinner10471 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
