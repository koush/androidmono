namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbsSpinner : android.widget.AdapterView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbsSpinner() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AbsSpinner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbsSpinner(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9062; 
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState9062, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _onRestoreInstanceState9062, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9063; 
		public virtual new android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState9063)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsSpinner.staticClass, _onSaveInstanceState9063)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9064; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _requestLayout9064); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _requestLayout9064); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9065; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _onMeasure9065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _onMeasure9065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9066; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				return @__env.CallIntMethod(this, _getCount9066); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsSpinner.staticClass, _getCount9066); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9067; 
		protected override android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams9067)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsSpinner.staticClass, _generateDefaultLayoutParams9067)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9068; 
		public override void setAdapter(android.widget.Adapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _setAdapter9068, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _setAdapter9068, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9069; 
		public virtual void setAdapter(android.widget.SpinnerAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _setAdapter9069, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _setAdapter9069, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9070; 
		public override android.widget.Adapter getAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, _getAdapter9070)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsSpinner.staticClass, _getAdapter9070)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView9071; 
		public override android.view.View getSelectedView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getSelectedView9071)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsSpinner.staticClass, _getSelectedView9071)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9072; 
		public override void setSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _setSelection9072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _setSelection9072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9073; 
		public virtual void setSelection(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				@__env.CallVoidMethod(this, _setSelection9073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsSpinner.staticClass, _setSelection9073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pointToPosition9074; 
		public virtual int pointToPosition(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsSpinner)) 
				return @__env.CallIntMethod(this, _pointToPosition9074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsSpinner.staticClass, _pointToPosition9074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner9075; 
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsSpinner.staticClass, _AbsSpinner9075, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner9076; 
		public AbsSpinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsSpinner.staticClass, _AbsSpinner9076, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSpinner9077; 
		public AbsSpinner(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsSpinner.staticClass, _AbsSpinner9077, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.AbsSpinner.staticClass = @__class; 
			global::android.widget.AbsSpinner._onRestoreInstanceState9062 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.AbsSpinner._onSaveInstanceState9063 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.AbsSpinner._requestLayout9064 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "requestLayout", "()V"); 
			global::android.widget.AbsSpinner._onMeasure9065 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.AbsSpinner._getCount9066 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getCount", "()I"); 
			global::android.widget.AbsSpinner._generateDefaultLayoutParams9067 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.AbsSpinner._setAdapter9068 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V"); 
			global::android.widget.AbsSpinner._setAdapter9069 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V"); 
			global::android.widget.AbsSpinner._getAdapter9070 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getAdapter", "()Landroid/widget/Adapter;"); 
			global::android.widget.AbsSpinner._getSelectedView9071 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "getSelectedView", "()Landroid/view/View;"); 
			global::android.widget.AbsSpinner._setSelection9072 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setSelection", "(I)V"); 
			global::android.widget.AbsSpinner._setSelection9073 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "setSelection", "(IZ)V"); 
			global::android.widget.AbsSpinner._pointToPosition9074 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "pointToPosition", "(II)I"); 
			global::android.widget.AbsSpinner._AbsSpinner9075 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AbsSpinner._AbsSpinner9076 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.AbsSpinner._AbsSpinner9077 = @__env.GetMethodID(global::android.widget.AbsSpinner.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
