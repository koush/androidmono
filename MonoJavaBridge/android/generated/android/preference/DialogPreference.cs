namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.DialogPreference_))]
	public abstract partial class DialogPreference : android.preference.Preference, android.content.DialogInterface_OnClickListener, android.content.DialogInterface_OnDismissListener, android.preference.PreferenceManager.OnActivityDestroyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick10247;
		protected override void onClick()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick10247);
		}
		internal static global::MonoJavaBridge.MethodId _onClick10248;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick10248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10249;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onRestoreInstanceState10249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10250;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onSaveInstanceState10250)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _showDialog10251;
		protected virtual void showDialog(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._showDialog10251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss10252;
		public virtual void onDismiss(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDismiss10252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDialogTitle10253;
		public virtual void setDialogTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle10253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogTitle(string arg0)
		{
			setDialogTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDialogTitle10254;
		public virtual void setDialogTitle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle10254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogTitle10255;
		public virtual global::java.lang.CharSequence getDialogTitle()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogTitle10255)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogMessage10256;
		public virtual void setDialogMessage(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage10256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogMessage(string arg0)
		{
			setDialogMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDialogMessage10257;
		public virtual void setDialogMessage(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage10257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogMessage10258;
		public virtual global::java.lang.CharSequence getDialogMessage()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogMessage10258)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogIcon10259;
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon10259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDialogIcon10260;
		public virtual void setDialogIcon(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon10260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogIcon10261;
		public virtual global::android.graphics.drawable.Drawable getDialogIcon()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogIcon10261)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveButtonText10262;
		public virtual void setPositiveButtonText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText10262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveButtonText10263;
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText10263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPositiveButtonText(string arg0)
		{
			setPositiveButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getPositiveButtonText10264;
		public virtual global::java.lang.CharSequence getPositiveButtonText()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getPositiveButtonText10264)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeButtonText10265;
		public virtual void setNegativeButtonText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText10265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeButtonText10266;
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText10266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setNegativeButtonText(string arg0)
		{
			setNegativeButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getNegativeButtonText10267;
		public virtual global::java.lang.CharSequence getNegativeButtonText()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getNegativeButtonText10267)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogLayoutResource10268;
		public virtual void setDialogLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogLayoutResource10268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogLayoutResource10269;
		public virtual int getDialogLayoutResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogLayoutResource10269);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialogBuilder10270;
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onPrepareDialogBuilder10270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialogView10271;
		protected virtual global::android.view.View onCreateDialogView()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onCreateDialogView10271)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onBindDialogView10272;
		protected virtual void onBindDialogView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onBindDialogView10272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed10273;
		protected virtual void onDialogClosed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDialogClosed10273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialog10274;
		public virtual global::android.app.Dialog getDialog()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialog10274)) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onActivityDestroy10275;
		public virtual void onActivityDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onActivityDestroy10275);
		}
		internal static global::MonoJavaBridge.MethodId _DialogPreference10276;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference10276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DialogPreference10277;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference10277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DialogPreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.DialogPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/DialogPreference"));
			global::android.preference.DialogPreference._onClick10247 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onClick", "()V");
			global::android.preference.DialogPreference._onClick10248 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.preference.DialogPreference._onRestoreInstanceState10249 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.DialogPreference._onSaveInstanceState10250 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.DialogPreference._showDialog10251 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V");
			global::android.preference.DialogPreference._onDismiss10252 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.preference.DialogPreference._setDialogTitle10253 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogTitle10254 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V");
			global::android.preference.DialogPreference._getDialogTitle10255 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogMessage10256 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogMessage10257 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V");
			global::android.preference.DialogPreference._getDialogMessage10258 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogIcon10259 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.preference.DialogPreference._setDialogIcon10260 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V");
			global::android.preference.DialogPreference._getDialogIcon10261 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.preference.DialogPreference._setPositiveButtonText10262 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V");
			global::android.preference.DialogPreference._setPositiveButtonText10263 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getPositiveButtonText10264 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setNegativeButtonText10265 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V");
			global::android.preference.DialogPreference._setNegativeButtonText10266 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getNegativeButtonText10267 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogLayoutResource10268 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V");
			global::android.preference.DialogPreference._getDialogLayoutResource10269 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I");
			global::android.preference.DialogPreference._onPrepareDialogBuilder10270 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.DialogPreference._onCreateDialogView10271 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;");
			global::android.preference.DialogPreference._onBindDialogView10272 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.DialogPreference._onDialogClosed10273 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.DialogPreference._getDialog10274 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;");
			global::android.preference.DialogPreference._onActivityDestroy10275 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V");
			global::android.preference.DialogPreference._DialogPreference10276 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.DialogPreference._DialogPreference10277 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.DialogPreference))]
	internal sealed partial class DialogPreference_ : android.preference.DialogPreference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogPreference_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static DialogPreference_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.DialogPreference_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/DialogPreference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
