namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.DialogPreference_))]
	public abstract partial class DialogPreference : android.preference.Preference, android.content.DialogInterface_OnClickListener, android.content.DialogInterface_OnDismissListener, android.preference.PreferenceManager.OnActivityDestroyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogPreference()
		{
			InitJNI();
		}
		protected DialogPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick6766;
		protected override void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onClick6766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick6766);
		}
		internal static global::MonoJavaBridge.MethodId _onClick6767;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onClick6767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick6767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState6768;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onRestoreInstanceState6768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onRestoreInstanceState6768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState6769;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._onSaveInstanceState6769)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onSaveInstanceState6769)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _showDialog6770;
		protected virtual void showDialog(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._showDialog6770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._showDialog6770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss6771;
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onDismiss6771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDismiss6771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDialogTitle6772;
		public virtual void setDialogTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogTitle6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogTitle(string arg0)
		{
			setDialogTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDialogTitle6773;
		public virtual void setDialogTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogTitle6773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle6773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogTitle6774;
		public virtual global::java.lang.CharSequence getDialogTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogTitle6774)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogTitle6774)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogMessage6775;
		public virtual void setDialogMessage(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogMessage6775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage6775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogMessage(string arg0)
		{
			setDialogMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDialogMessage6776;
		public virtual void setDialogMessage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogMessage6776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage6776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogMessage6777;
		public virtual global::java.lang.CharSequence getDialogMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogMessage6777)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogMessage6777)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogIcon6778;
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogIcon6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDialogIcon6779;
		public virtual void setDialogIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogIcon6779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon6779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogIcon6780;
		public virtual global::android.graphics.drawable.Drawable getDialogIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogIcon6780)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogIcon6780)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveButtonText6781;
		public virtual void setPositiveButtonText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setPositiveButtonText6781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText6781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveButtonText6782;
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setPositiveButtonText6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPositiveButtonText(string arg0)
		{
			setPositiveButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getPositiveButtonText6783;
		public virtual global::java.lang.CharSequence getPositiveButtonText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getPositiveButtonText6783)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getPositiveButtonText6783)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeButtonText6784;
		public virtual void setNegativeButtonText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setNegativeButtonText6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeButtonText6785;
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setNegativeButtonText6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setNegativeButtonText(string arg0)
		{
			setNegativeButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getNegativeButtonText6786;
		public virtual global::java.lang.CharSequence getNegativeButtonText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getNegativeButtonText6786)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getNegativeButtonText6786)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogLayoutResource6787;
		public virtual void setDialogLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogLayoutResource6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogLayoutResource6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogLayoutResource6788;
		public virtual int getDialogLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogLayoutResource6788);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogLayoutResource6788);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialogBuilder6789;
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onPrepareDialogBuilder6789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onPrepareDialogBuilder6789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialogView6790;
		protected virtual global::android.view.View onCreateDialogView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._onCreateDialogView6790)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onCreateDialogView6790)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onBindDialogView6791;
		protected virtual void onBindDialogView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onBindDialogView6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onBindDialogView6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed6792;
		protected virtual void onDialogClosed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onDialogClosed6792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDialogClosed6792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialog6793;
		public virtual global::android.app.Dialog getDialog() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialog6793)) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialog6793)) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onActivityDestroy6794;
		public virtual void onActivityDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onActivityDestroy6794);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onActivityDestroy6794);
		}
		internal static global::MonoJavaBridge.MethodId _DialogPreference6795;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference6795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DialogPreference6796;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference6796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.DialogPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/DialogPreference"));
			global::android.preference.DialogPreference._onClick6766 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onClick", "()V");
			global::android.preference.DialogPreference._onClick6767 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.preference.DialogPreference._onRestoreInstanceState6768 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.DialogPreference._onSaveInstanceState6769 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.DialogPreference._showDialog6770 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V");
			global::android.preference.DialogPreference._onDismiss6771 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.preference.DialogPreference._setDialogTitle6772 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogTitle6773 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V");
			global::android.preference.DialogPreference._getDialogTitle6774 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogMessage6775 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogMessage6776 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V");
			global::android.preference.DialogPreference._getDialogMessage6777 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogIcon6778 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.preference.DialogPreference._setDialogIcon6779 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V");
			global::android.preference.DialogPreference._getDialogIcon6780 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.preference.DialogPreference._setPositiveButtonText6781 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V");
			global::android.preference.DialogPreference._setPositiveButtonText6782 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getPositiveButtonText6783 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setNegativeButtonText6784 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V");
			global::android.preference.DialogPreference._setNegativeButtonText6785 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getNegativeButtonText6786 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogLayoutResource6787 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V");
			global::android.preference.DialogPreference._getDialogLayoutResource6788 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I");
			global::android.preference.DialogPreference._onPrepareDialogBuilder6789 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.DialogPreference._onCreateDialogView6790 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;");
			global::android.preference.DialogPreference._onBindDialogView6791 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.DialogPreference._onDialogClosed6792 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.DialogPreference._getDialog6793 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;");
			global::android.preference.DialogPreference._onActivityDestroy6794 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V");
			global::android.preference.DialogPreference._DialogPreference6795 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.DialogPreference._DialogPreference6796 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.DialogPreference))]
	public sealed partial class DialogPreference_ : android.preference.DialogPreference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogPreference_()
		{
			InitJNI();
		}
		internal DialogPreference_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.DialogPreference_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/DialogPreference"));
		}
	}
}
