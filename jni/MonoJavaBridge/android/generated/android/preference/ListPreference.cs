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
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
			set
			{
				setValue(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue10292;
		public virtual global::java.lang.String getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getValue10292)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getValue10292)) as java.lang.String;
		}
		public new string Entry
		{
			get
			{
				return getEntry().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntry10293;
		public virtual global::java.lang.CharSequence getEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getEntry10293)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntry10293)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setValue10294;
		public virtual void setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setValue10294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setValue10294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.CharSequence[] Entries
		{
			get
			{
				return getEntries();
			}
			set
			{
				setEntries(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntries10295;
		public virtual global::java.lang.CharSequence[] getEntries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getEntries10295)) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntries10295)) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10296;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onRestoreInstanceState10296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onRestoreInstanceState10296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10297;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._onSaveInstanceState10297)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onSaveInstanceState10297)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue10298;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._onGetDefaultValue10298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onGetDefaultValue10298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue10299;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onSetInitialValue10299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onSetInitialValue10299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialogBuilder10300;
		protected override void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onPrepareDialogBuilder10300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onPrepareDialogBuilder10300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDialogClosed10301;
		protected override void onDialogClosed(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._onDialogClosed10301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onDialogClosed10301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntries10302;
		public virtual void setEntries(java.lang.CharSequence[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntries10302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntries10302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntries10303;
		public virtual void setEntries(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntries10303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntries10303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntryValues10304;
		public virtual void setEntryValues(java.lang.CharSequence[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntryValues10304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntryValues10304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntryValues10305;
		public virtual void setEntryValues(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setEntryValues10305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntryValues10305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.CharSequence[] EntryValues
		{
			get
			{
				return getEntryValues();
			}
			set
			{
				setEntryValues(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntryValues10306;
		public virtual global::java.lang.CharSequence[] getEntryValues()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.ListPreference._getEntryValues10306)) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntryValues10306)) as java.lang.CharSequence[];
		}
		public new int ValueIndex
		{
			set
			{
				setValueIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setValueIndex10307;
		public virtual void setValueIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.ListPreference._setValueIndex10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setValueIndex10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findIndexOfValue10308;
		public virtual int findIndexOfValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.ListPreference._findIndexOfValue10308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._findIndexOfValue10308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ListPreference10309;
		public ListPreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._ListPreference10309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListPreference10310;
		public ListPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._ListPreference10310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.ListPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/ListPreference"));
			global::android.preference.ListPreference._getValue10292 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getValue", "()Ljava/lang/String;");
			global::android.preference.ListPreference._getEntry10293 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getEntry", "()Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._setValue10294 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::android.preference.ListPreference._getEntries10295 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getEntries", "()[Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._onRestoreInstanceState10296 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.ListPreference._onSaveInstanceState10297 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.ListPreference._onGetDefaultValue10298 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.ListPreference._onSetInitialValue10299 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.ListPreference._onPrepareDialogBuilder10300 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.ListPreference._onDialogClosed10301 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.ListPreference._setEntries10302 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntries", "([Ljava/lang/CharSequence;)V");
			global::android.preference.ListPreference._setEntries10303 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntries", "(I)V");
			global::android.preference.ListPreference._setEntryValues10304 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntryValues", "([Ljava/lang/CharSequence;)V");
			global::android.preference.ListPreference._setEntryValues10305 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setEntryValues", "(I)V");
			global::android.preference.ListPreference._getEntryValues10306 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "getEntryValues", "()[Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._setValueIndex10307 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "setValueIndex", "(I)V");
			global::android.preference.ListPreference._findIndexOfValue10308 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "findIndexOfValue", "(Ljava/lang/String;)I");
			global::android.preference.ListPreference._ListPreference10309 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.ListPreference._ListPreference10310 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
