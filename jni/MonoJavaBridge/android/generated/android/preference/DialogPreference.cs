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
		internal static global::MonoJavaBridge.MethodId _onClick10200;
		protected override void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onClick10200);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick10200);
		}
		internal static global::MonoJavaBridge.MethodId _onClick10201;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onClick10201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onClick10201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10202;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onRestoreInstanceState10202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onRestoreInstanceState10202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10203;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._onSaveInstanceState10203)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onSaveInstanceState10203)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _showDialog10204;
		protected virtual void showDialog(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._showDialog10204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._showDialog10204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss10205;
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onDismiss10205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDismiss10205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDialogTitle10206;
		public virtual void setDialogTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogTitle10206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle10206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogTitle(string arg0)
		{
			setDialogTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDialogTitle10207;
		public virtual void setDialogTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogTitle10207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogTitle10207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogTitle10208;
		public virtual global::java.lang.CharSequence getDialogTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogTitle10208)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogTitle10208)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogMessage10209;
		public virtual void setDialogMessage(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogMessage10209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage10209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDialogMessage(string arg0)
		{
			setDialogMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDialogMessage10210;
		public virtual void setDialogMessage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogMessage10210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogMessage10210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogMessage10211;
		public virtual global::java.lang.CharSequence getDialogMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogMessage10211)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogMessage10211)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogIcon10212;
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogIcon10212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon10212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDialogIcon10213;
		public virtual void setDialogIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogIcon10213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogIcon10213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogIcon10214;
		public virtual global::android.graphics.drawable.Drawable getDialogIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogIcon10214)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogIcon10214)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveButtonText10215;
		public virtual void setPositiveButtonText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setPositiveButtonText10215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText10215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveButtonText10216;
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setPositiveButtonText10216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setPositiveButtonText10216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPositiveButtonText(string arg0)
		{
			setPositiveButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getPositiveButtonText10217;
		public virtual global::java.lang.CharSequence getPositiveButtonText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getPositiveButtonText10217)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getPositiveButtonText10217)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeButtonText10218;
		public virtual void setNegativeButtonText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setNegativeButtonText10218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText10218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeButtonText10219;
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setNegativeButtonText10219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setNegativeButtonText10219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setNegativeButtonText(string arg0)
		{
			setNegativeButtonText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getNegativeButtonText10220;
		public virtual global::java.lang.CharSequence getNegativeButtonText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getNegativeButtonText10220)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getNegativeButtonText10220)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setDialogLayoutResource10221;
		public virtual void setDialogLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._setDialogLayoutResource10221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._setDialogLayoutResource10221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialogLayoutResource10222;
		public virtual int getDialogLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialogLayoutResource10222);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialogLayoutResource10222);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialogBuilder10223;
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onPrepareDialogBuilder10223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onPrepareDialogBuilder10223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialogView10224;
		protected virtual global::android.view.View onCreateDialogView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._onCreateDialogView10224)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onCreateDialogView10224)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onBindDialogView10225;
		protected virtual void onBindDialogView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onBindDialogView10225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onBindDialogView10225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed10226;
		protected virtual void onDialogClosed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onDialogClosed10226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onDialogClosed10226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDialog10227;
		public virtual global::android.app.Dialog getDialog() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.DialogPreference._getDialog10227)) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._getDialog10227)) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onActivityDestroy10228;
		public virtual void onActivityDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.DialogPreference._onActivityDestroy10228);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._onActivityDestroy10228);
		}
		internal static global::MonoJavaBridge.MethodId _DialogPreference10229;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference10229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DialogPreference10230;
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.DialogPreference.staticClass, global::android.preference.DialogPreference._DialogPreference10230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.DialogPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/DialogPreference"));
			global::android.preference.DialogPreference._onClick10200 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onClick", "()V");
			global::android.preference.DialogPreference._onClick10201 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.preference.DialogPreference._onRestoreInstanceState10202 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.DialogPreference._onSaveInstanceState10203 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.DialogPreference._showDialog10204 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V");
			global::android.preference.DialogPreference._onDismiss10205 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.preference.DialogPreference._setDialogTitle10206 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogTitle10207 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V");
			global::android.preference.DialogPreference._getDialogTitle10208 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogMessage10209 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._setDialogMessage10210 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V");
			global::android.preference.DialogPreference._getDialogMessage10211 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogIcon10212 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.preference.DialogPreference._setDialogIcon10213 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V");
			global::android.preference.DialogPreference._getDialogIcon10214 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.preference.DialogPreference._setPositiveButtonText10215 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V");
			global::android.preference.DialogPreference._setPositiveButtonText10216 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getPositiveButtonText10217 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setNegativeButtonText10218 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V");
			global::android.preference.DialogPreference._setNegativeButtonText10219 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V");
			global::android.preference.DialogPreference._getNegativeButtonText10220 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;");
			global::android.preference.DialogPreference._setDialogLayoutResource10221 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V");
			global::android.preference.DialogPreference._getDialogLayoutResource10222 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I");
			global::android.preference.DialogPreference._onPrepareDialogBuilder10223 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.DialogPreference._onCreateDialogView10224 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;");
			global::android.preference.DialogPreference._onBindDialogView10225 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V");
			global::android.preference.DialogPreference._onDialogClosed10226 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.DialogPreference._getDialog10227 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;");
			global::android.preference.DialogPreference._onActivityDestroy10228 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V");
			global::android.preference.DialogPreference._DialogPreference10229 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.DialogPreference._DialogPreference10230 = @__env.GetMethodIDNoThrow(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
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
