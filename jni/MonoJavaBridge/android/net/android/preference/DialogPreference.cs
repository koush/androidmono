namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DialogPreference : android.preference.Preference, android.content.DialogInterface_OnClickListener, android.content.DialogInterface_OnDismissListener, android.preference.PreferenceManager.OnActivityDestroyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DialogPreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.DialogPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DialogPreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick5911; 
		protected override void onClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onClick5911); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick5911); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick5912; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onClick5912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick5912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5913; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onRestoreInstanceState5913, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onRestoreInstanceState5913, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5914; 
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._onSaveInstanceState5914)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onSaveInstanceState5914)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showDialog5915; 
		protected virtual void showDialog(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._showDialog5915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._showDialog5915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss5916; 
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onDismiss5916, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDismiss5916, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogTitle5917; 
		public virtual void setDialogTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogTitle5917, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle5917, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogTitle5918; 
		public virtual void setDialogTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogTitle5918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle5918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogTitle5919; 
		public virtual global::java.lang.CharSequence getDialogTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialogTitle5919)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogTitle5919)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogMessage5920; 
		public virtual void setDialogMessage(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogMessage5920, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage5920, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogMessage5921; 
		public virtual void setDialogMessage(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogMessage5921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage5921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogMessage5922; 
		public virtual global::java.lang.CharSequence getDialogMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialogMessage5922)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogMessage5922)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogIcon5923; 
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogIcon5923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon5923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogIcon5924; 
		public virtual void setDialogIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogIcon5924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon5924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogIcon5925; 
		public virtual global::android.graphics.drawable.Drawable getDialogIcon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialogIcon5925)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogIcon5925)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositiveButtonText5926; 
		public virtual void setPositiveButtonText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setPositiveButtonText5926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText5926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositiveButtonText5927; 
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setPositiveButtonText5927, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText5927, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositiveButtonText5928; 
		public virtual global::java.lang.CharSequence getPositiveButtonText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getPositiveButtonText5928)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getPositiveButtonText5928)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNegativeButtonText5929; 
		public virtual void setNegativeButtonText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setNegativeButtonText5929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText5929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNegativeButtonText5930; 
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setNegativeButtonText5930, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText5930, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNegativeButtonText5931; 
		public virtual global::java.lang.CharSequence getNegativeButtonText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getNegativeButtonText5931)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getNegativeButtonText5931)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogLayoutResource5932; 
		public virtual void setDialogLayoutResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogLayoutResource5932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogLayoutResource5932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogLayoutResource5933; 
		public virtual int getDialogLayoutResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.preference.DialogPreference._getDialogLayoutResource5933); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogLayoutResource5933); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialogBuilder5934; 
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onPrepareDialogBuilder5934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onPrepareDialogBuilder5934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialogView5935; 
		protected virtual global::android.view.View onCreateDialogView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._onCreateDialogView5935)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onCreateDialogView5935)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindDialogView5936; 
		protected virtual void onBindDialogView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onBindDialogView5936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onBindDialogView5936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed5937; 
		protected virtual void onDialogClosed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onDialogClosed5937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDialogClosed5937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialog5938; 
		public virtual global::android.app.Dialog getDialog() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialog5938)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialog5938)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityDestroy5939; 
		public virtual void onActivityDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onActivityDestroy5939); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onActivityDestroy5939); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialogPreference5940; 
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference5940, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialogPreference5941; 
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference5941, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.DialogPreference.staticClass = @__class; 
			global::android.preference.DialogPreference._onClick5911 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onClick", "()V"); 
			global::android.preference.DialogPreference._onClick5912 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.preference.DialogPreference._onRestoreInstanceState5913 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.DialogPreference._onSaveInstanceState5914 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.DialogPreference._showDialog5915 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V"); 
			global::android.preference.DialogPreference._onDismiss5916 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V"); 
			global::android.preference.DialogPreference._setDialogTitle5917 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._setDialogTitle5918 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V"); 
			global::android.preference.DialogPreference._getDialogTitle5919 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setDialogMessage5920 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._setDialogMessage5921 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V"); 
			global::android.preference.DialogPreference._getDialogMessage5922 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setDialogIcon5923 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.preference.DialogPreference._setDialogIcon5924 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V"); 
			global::android.preference.DialogPreference._getDialogIcon5925 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.preference.DialogPreference._setPositiveButtonText5926 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V"); 
			global::android.preference.DialogPreference._setPositiveButtonText5927 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._getPositiveButtonText5928 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setNegativeButtonText5929 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V"); 
			global::android.preference.DialogPreference._setNegativeButtonText5930 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._getNegativeButtonText5931 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setDialogLayoutResource5932 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V"); 
			global::android.preference.DialogPreference._getDialogLayoutResource5933 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I"); 
			global::android.preference.DialogPreference._onPrepareDialogBuilder5934 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V"); 
			global::android.preference.DialogPreference._onCreateDialogView5935 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;"); 
			global::android.preference.DialogPreference._onBindDialogView5936 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V"); 
			global::android.preference.DialogPreference._onDialogClosed5937 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V"); 
			global::android.preference.DialogPreference._getDialog5938 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;"); 
			global::android.preference.DialogPreference._onActivityDestroy5939 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V"); 
			global::android.preference.DialogPreference._DialogPreference5940 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.DialogPreference._DialogPreference5941 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
