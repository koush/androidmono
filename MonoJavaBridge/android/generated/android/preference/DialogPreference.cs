namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.DialogPreference_))]
	public abstract partial class DialogPreference : android.preference.Preference, android.content.DialogInterface_OnClickListener, android.content.DialogInterface_OnDismissListener, android.preference.PreferenceManager.OnActivityDestroyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onClick()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onClick", "()V", ref global::android.preference.DialogPreference._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V", ref global::android.preference.DialogPreference._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.preference.DialogPreference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.preference.DialogPreference._m3) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void showDialog(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V", ref global::android.preference.DialogPreference._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onDismiss(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V", ref global::android.preference.DialogPreference._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setDialogTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V", ref global::android.preference.DialogPreference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogTitle(string arg0)
		{
			setDialogTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setDialogTitle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V", ref global::android.preference.DialogPreference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.CharSequence getDialogTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;", ref global::android.preference.DialogPreference._m8) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDialogMessage(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V", ref global::android.preference.DialogPreference._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogMessage(string arg0)
		{
			setDialogMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setDialogMessage(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V", ref global::android.preference.DialogPreference._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.CharSequence getDialogMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;", ref global::android.preference.DialogPreference._m11) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.preference.DialogPreference._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setDialogIcon(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V", ref global::android.preference.DialogPreference._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.graphics.drawable.Drawable getDialogIcon()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;", ref global::android.preference.DialogPreference._m14) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setPositiveButtonText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V", ref global::android.preference.DialogPreference._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V", ref global::android.preference.DialogPreference._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPositiveButtonText(string arg0)
		{
			setPositiveButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.CharSequence getPositiveButtonText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;", ref global::android.preference.DialogPreference._m17) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setNegativeButtonText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V", ref global::android.preference.DialogPreference._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V", ref global::android.preference.DialogPreference._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setNegativeButtonText(string arg0)
		{
			setNegativeButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.CharSequence getNegativeButtonText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;", ref global::android.preference.DialogPreference._m20) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setDialogLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V", ref global::android.preference.DialogPreference._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getDialogLayoutResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I", ref global::android.preference.DialogPreference._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V", ref global::android.preference.DialogPreference._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected virtual global::android.view.View onCreateDialogView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;", ref global::android.preference.DialogPreference._m24) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected virtual void onBindDialogView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V", ref global::android.preference.DialogPreference._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual void onDialogClosed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V", ref global::android.preference.DialogPreference._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.app.Dialog getDialog()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;", ref global::android.preference.DialogPreference._m27) as android.app.Dialog;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void onActivityDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V", ref global::android.preference.DialogPreference._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.DialogPreference._m29.native == global::System.IntPtr.Zero)
				global::android.preference.DialogPreference._m29 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.DialogPreference._m30.native == global::System.IntPtr.Zero)
				global::android.preference.DialogPreference._m30 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DialogPreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.DialogPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/DialogPreference"));
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
