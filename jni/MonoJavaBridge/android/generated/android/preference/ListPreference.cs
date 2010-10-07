namespace android.preference
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ListPreference : android.preference.DialogPreference
	{
		internal new static global::java.lang.Class staticClass;
		static ListPreference()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.ListPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.preference.ListPreference(@__env);
			}
		}
		protected ListPreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue6535;
		public virtual global::java.lang.String getValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.ListPreference._getValue6535));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getValue6535));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntry6536;
		public virtual global::java.lang.CharSequence getEntry() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.ListPreference._getEntry6536));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntry6536));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setValue6537;
		public virtual void setValue(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._setValue6537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setValue6537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntries6538;
		public virtual global::java.lang.CharSequence[] getEntries() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.ListPreference._getEntries6538));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntries6538));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState6539;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._onRestoreInstanceState6539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onRestoreInstanceState6539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState6540;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.ListPreference._onSaveInstanceState6540));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onSaveInstanceState6540));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue6541;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.ListPreference._onGetDefaultValue6541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onGetDefaultValue6541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue6542;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._onSetInitialValue6542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onSetInitialValue6542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialogBuilder6543;
		protected override void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._onPrepareDialogBuilder6543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onPrepareDialogBuilder6543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed6544;
		protected override void onDialogClosed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._onDialogClosed6544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._onDialogClosed6544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntries6545;
		public virtual void setEntries(java.lang.CharSequence[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._setEntries6545, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntries6545, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntries6546;
		public virtual void setEntries(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._setEntries6546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntries6546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntryValues6547;
		public virtual void setEntryValues(java.lang.CharSequence[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._setEntryValues6547, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntryValues6547, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntryValues6548;
		public virtual void setEntryValues(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._setEntryValues6548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setEntryValues6548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntryValues6549;
		public virtual global::java.lang.CharSequence[] getEntryValues() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.ListPreference._getEntryValues6549));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._getEntryValues6549));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setValueIndex6550;
		public virtual void setValueIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.ListPreference._setValueIndex6550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._setValueIndex6550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findIndexOfValue6551;
		public virtual int findIndexOfValue(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.preference.ListPreference._findIndexOfValue6551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.preference.ListPreference.staticClass, global::android.preference.ListPreference._findIndexOfValue6551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListPreference6552;
		public ListPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._ListPreference6552, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListPreference6553;
		public ListPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.preference.ListPreference.staticClass, global::android.preference.ListPreference._ListPreference6553, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.ListPreference.staticClass = @__class;
			global::android.preference.ListPreference._getValue6535 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getValue", "()Ljava/lang/String;");
			global::android.preference.ListPreference._getEntry6536 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getEntry", "()Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._setValue6537 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::android.preference.ListPreference._getEntries6538 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getEntries", "()[Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._onRestoreInstanceState6539 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.preference.ListPreference._onSaveInstanceState6540 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.preference.ListPreference._onGetDefaultValue6541 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.ListPreference._onSetInitialValue6542 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.ListPreference._onPrepareDialogBuilder6543 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V");
			global::android.preference.ListPreference._onDialogClosed6544 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onDialogClosed", "(Z)V");
			global::android.preference.ListPreference._setEntries6545 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntries", "([Ljava/lang/CharSequence;)V");
			global::android.preference.ListPreference._setEntries6546 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntries", "(I)V");
			global::android.preference.ListPreference._setEntryValues6547 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntryValues", "([Ljava/lang/CharSequence;)V");
			global::android.preference.ListPreference._setEntryValues6548 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntryValues", "(I)V");
			global::android.preference.ListPreference._getEntryValues6549 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getEntryValues", "()[Ljava/lang/CharSequence;");
			global::android.preference.ListPreference._setValueIndex6550 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setValueIndex", "(I)V");
			global::android.preference.ListPreference._findIndexOfValue6551 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "findIndexOfValue", "(Ljava/lang/String;)I");
			global::android.preference.ListPreference._ListPreference6552 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.ListPreference._ListPreference6553 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
