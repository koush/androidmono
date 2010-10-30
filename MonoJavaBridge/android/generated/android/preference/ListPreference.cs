namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ListPreference : android.preference.DialogPreference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.preference.ListPreference.staticClass, "getValue", "()Ljava/lang/String;", ref global::android.preference.ListPreference._m0) as java.lang.String;
		}
		public new string Entry
		{
			get
			{
				return getEntry().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.CharSequence getEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.preference.ListPreference.staticClass, "getEntry", "()Ljava/lang/CharSequence;", ref global::android.preference.ListPreference._m1) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "setValue", "(Ljava/lang/String;)V", ref global::android.preference.ListPreference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.CharSequence[] getEntries()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.preference.ListPreference.staticClass, "getEntries", "()[Ljava/lang/CharSequence;", ref global::android.preference.ListPreference._m3) as java.lang.CharSequence[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.preference.ListPreference._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.preference.ListPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.preference.ListPreference._m5) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.ListPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", ref global::android.preference.ListPreference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V", ref global::android.preference.ListPreference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V", ref global::android.preference.ListPreference._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void onDialogClosed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "onDialogClosed", "(Z)V", ref global::android.preference.ListPreference._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setEntries(java.lang.CharSequence[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "setEntries", "([Ljava/lang/CharSequence;)V", ref global::android.preference.ListPreference._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setEntries(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "setEntries", "(I)V", ref global::android.preference.ListPreference._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setEntryValues(java.lang.CharSequence[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "setEntryValues", "([Ljava/lang/CharSequence;)V", ref global::android.preference.ListPreference._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setEntryValues(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "setEntryValues", "(I)V", ref global::android.preference.ListPreference._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.CharSequence[] getEntryValues()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.preference.ListPreference.staticClass, "getEntryValues", "()[Ljava/lang/CharSequence;", ref global::android.preference.ListPreference._m14) as java.lang.CharSequence[];
		}
		public new int ValueIndex
		{
			set
			{
				setValueIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setValueIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.ListPreference.staticClass, "setValueIndex", "(I)V", ref global::android.preference.ListPreference._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int findIndexOfValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.preference.ListPreference.staticClass, "findIndexOfValue", "(Ljava/lang/String;)I", ref global::android.preference.ListPreference._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public ListPreference(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.ListPreference._m17.native == global::System.IntPtr.Zero)
				global::android.preference.ListPreference._m17 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public ListPreference(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.preference.ListPreference._m18.native == global::System.IntPtr.Zero)
				global::android.preference.ListPreference._m18 = @__env.GetMethodIDNoThrow(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ListPreference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.ListPreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/ListPreference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
