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
		internal static global::net.sf.jni4net.jni.MethodId _onClick6490;
		protected override void onClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onClick6490);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick6490);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick6491;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onClick6491, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick6491, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState6492;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onRestoreInstanceState6492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onRestoreInstanceState6492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState6493;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._onSaveInstanceState6493));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onSaveInstanceState6493));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showDialog6494;
		protected virtual void showDialog(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._showDialog6494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._showDialog6494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss6495;
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onDismiss6495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDismiss6495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogTitle6496;
		public virtual void setDialogTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogTitle6496, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle6496, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setDialogTitle(string arg0)
		{
			setDialogTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogTitle6497;
		public virtual void setDialogTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogTitle6497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle6497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDialogTitle6498;
		public virtual global::java.lang.CharSequence getDialogTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialogTitle6498));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogTitle6498));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogMessage6499;
		public virtual void setDialogMessage(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogMessage6499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage6499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setDialogMessage(string arg0)
		{
			setDialogMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogMessage6500;
		public virtual void setDialogMessage(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogMessage6500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage6500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDialogMessage6501;
		public virtual global::java.lang.CharSequence getDialogMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialogMessage6501));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogMessage6501));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogIcon6502;
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogIcon6502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon6502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogIcon6503;
		public virtual void setDialogIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogIcon6503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon6503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDialogIcon6504;
		public virtual global::android.graphics.drawable.Drawable getDialogIcon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialogIcon6504));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogIcon6504));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPositiveButtonText6505;
		public virtual void setPositiveButtonText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setPositiveButtonText6505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText6505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPositiveButtonText6506;
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setPositiveButtonText6506, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText6506, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setPositiveButtonText(string arg0)
		{
			setPositiveButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositiveButtonText6507;
		public virtual global::java.lang.CharSequence getPositiveButtonText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getPositiveButtonText6507));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getPositiveButtonText6507));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNegativeButtonText6508;
		public virtual void setNegativeButtonText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setNegativeButtonText6508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText6508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNegativeButtonText6509;
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setNegativeButtonText6509, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText6509, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setNegativeButtonText(string arg0)
		{
			setNegativeButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNegativeButtonText6510;
		public virtual global::java.lang.CharSequence getNegativeButtonText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getNegativeButtonText6510));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getNegativeButtonText6510));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDialogLayoutResource6511;
		public virtual void setDialogLayoutResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._setDialogLayoutResource6511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogLayoutResource6511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDialogLayoutResource6512;
		public virtual int getDialogLayoutResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.DialogPreference._getDialogLayoutResource6512);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogLayoutResource6512);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialogBuilder6513;
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onPrepareDialogBuilder6513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onPrepareDialogBuilder6513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialogView6514;
		protected virtual global::android.view.View onCreateDialogView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._onCreateDialogView6514));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onCreateDialogView6514));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBindDialogView6515;
		protected virtual void onBindDialogView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onBindDialogView6515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onBindDialogView6515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed6516;
		protected virtual void onDialogClosed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onDialogClosed6516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDialogClosed6516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDialog6517;
		public virtual global::android.app.Dialog getDialog() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.DialogPreference._getDialog6517));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialog6517));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onActivityDestroy6518;
		public virtual void onActivityDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.DialogPreference._onActivityDestroy6518);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onActivityDestroy6518);
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialogPreference6519;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference6519, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialogPreference6520;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference6520, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.DialogPreference.staticClass = @__class;
			global::android.preference.DialogPreference._onClick6490 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onClick", "()V");
			global::android.preference.DialogPreference._onClick6491 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.preference.DialogPreference._onRestoreInstanceState6492 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.DialogPreference._onSaveInstanceState6493 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.DialogPreference._showDialog6494 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V");
			global::android.preference.DialogPreference._onDismiss6495 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.preference.DialogPreference._setDialogTitle6496 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogTitle6497 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V");
			global::android.preference.DialogPreference._getDialogTitle6498 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogMessage6499 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogMessage6500 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V");
			global::android.preference.DialogPreference._getDialogMessage6501 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogIcon6502 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.preference.DialogPreference._setDialogIcon6503 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V");
			global::android.preference.DialogPreference._getDialogIcon6504 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.preference.DialogPreference._setPositiveButtonText6505 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V");
			global::android.preference.DialogPreference._setPositiveButtonText6506 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getPositiveButtonText6507 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setNegativeButtonText6508 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V");
			global::android.preference.DialogPreference._setNegativeButtonText6509 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getNegativeButtonText6510 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogLayoutResource6511 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V");
			global::android.preference.DialogPreference._getDialogLayoutResource6512 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I");
			global::android.preference.DialogPreference._onPrepareDialogBuilder6513 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.DialogPreference._onCreateDialogView6514 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;");
			global::android.preference.DialogPreference._onBindDialogView6515 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.DialogPreference._onDialogClosed6516 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.DialogPreference._getDialog6517 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;");
			global::android.preference.DialogPreference._onActivityDestroy6518 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V");
			global::android.preference.DialogPreference._DialogPreference6519 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.DialogPreference._DialogPreference6520 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
