namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ListPreference : android.preference.DialogPreference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListPreference()
		{
			InitJNI();
		}
		protected ListPreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getValue6811;
		public virtual global::java.lang.String getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getValue6811)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getValue6811)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEntry6812;
		public virtual global::java.lang.CharSequence getEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getEntry6812)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntry6812)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setValue6813;
		public virtual void setValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setValue6813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setValue6813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntries6814;
		public virtual global::java.lang.CharSequence[] getEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getEntries6814)) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntries6814)) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState6815;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onRestoreInstanceState6815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onRestoreInstanceState6815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState6816;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._onSaveInstanceState6816)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onSaveInstanceState6816)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue6817;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._onGetDefaultValue6817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onGetDefaultValue6817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue6818;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onSetInitialValue6818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onSetInitialValue6818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialogBuilder6819;
		protected override void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onPrepareDialogBuilder6819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onPrepareDialogBuilder6819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed6820;
		protected override void onDialogClosed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onDialogClosed6820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onDialogClosed6820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntries6821;
		public virtual void setEntries(java.lang.CharSequence[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntries6821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntries6821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntries6822;
		public virtual void setEntries(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntries6822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntries6822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntryValues6823;
		public virtual void setEntryValues(java.lang.CharSequence[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntryValues6823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntryValues6823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntryValues6824;
		public virtual void setEntryValues(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntryValues6824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntryValues6824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntryValues6825;
		public virtual global::java.lang.CharSequence[] getEntryValues() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getEntryValues6825)) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntryValues6825)) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _setValueIndex6826;
		public virtual void setValueIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setValueIndex6826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setValueIndex6826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findIndexOfValue6827;
		public virtual int findIndexOfValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.ListPreference._findIndexOfValue6827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._findIndexOfValue6827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ListPreference6828;
		public ListPreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._ListPreference6828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListPreference6829;
		public ListPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._ListPreference6829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.ListPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/ListPreference"));
			global::android.preference.ListPreference._getValue6811 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getValue", "()Ljava/lang/String;");
			global::android.preference.ListPreference._getEntry6812 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getEntry", "()Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._setValue6813 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::android.preference.ListPreference._getEntries6814 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getEntries", "()[Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._onRestoreInstanceState6815 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.ListPreference._onSaveInstanceState6816 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.ListPreference._onGetDefaultValue6817 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.ListPreference._onSetInitialValue6818 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.ListPreference._onPrepareDialogBuilder6819 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.ListPreference._onDialogClosed6820 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.ListPreference._setEntries6821 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntries", "([Ljava/lang/CharSequence;)V");
			global::android.preference.ListPreference._setEntries6822 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntries", "(I)V");
			global::android.preference.ListPreference._setEntryValues6823 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntryValues", "([Ljava/lang/CharSequence;)V");
			global::android.preference.ListPreference._setEntryValues6824 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntryValues", "(I)V");
			global::android.preference.ListPreference._getEntryValues6825 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getEntryValues", "()[Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._setValueIndex6826 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setValueIndex", "(I)V");
			global::android.preference.ListPreference._findIndexOfValue6827 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "findIndexOfValue", "(Ljava/lang/String;)I");
			global::android.preference.ListPreference._ListPreference6828 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.ListPreference._ListPreference6829 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
