namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ListPreference : android.preference.DialogPreference
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ListPreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.ListPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getValue5682; 
		public virtual java.lang.String getValue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getValue5682)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.ListPreference.staticClass, _getValue5682)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEntry5683; 
		public virtual java.lang.CharSequence getEntry() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getEntry5683)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.ListPreference.staticClass, _getEntry5683)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValue5684; 
		public virtual void setValue(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _setValue5684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _setValue5684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEntries5685; 
		public virtual java.lang.CharSequence[] getEntries() 
		{ 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getEntries5685)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.ListPreference.staticClass, _getEntries5685)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5686; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState5686, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _onRestoreInstanceState5686, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5687; 
		protected override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState5687)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.ListPreference.staticClass, _onSaveInstanceState5687)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5688; 
		protected override java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _onGetDefaultValue5688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.ListPreference.staticClass, _onGetDefaultValue5688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5689; 
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _onSetInitialValue5689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _onSetInitialValue5689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialogBuilder5690; 
		protected override void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _onPrepareDialogBuilder5690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _onPrepareDialogBuilder5690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed5691; 
		protected override void onDialogClosed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _onDialogClosed5691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _onDialogClosed5691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEntries5692; 
		public virtual void setEntries(java.lang.CharSequence[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _setEntries5692, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _setEntries5692, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEntries5693; 
		public virtual void setEntries(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _setEntries5693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _setEntries5693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEntryValues5694; 
		public virtual void setEntryValues(java.lang.CharSequence[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _setEntryValues5694, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _setEntryValues5694, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEntryValues5695; 
		public virtual void setEntryValues(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _setEntryValues5695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _setEntryValues5695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEntryValues5696; 
		public virtual java.lang.CharSequence[] getEntryValues() 
		{ 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getEntryValues5696)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.ListPreference.staticClass, _getEntryValues5696)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValueIndex5697; 
		public virtual void setValueIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				@__env.CallVoidMethod(this, _setValueIndex5697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.ListPreference.staticClass, _setValueIndex5697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findIndexOfValue5698; 
		public virtual int findIndexOfValue(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.ListPreference)) 
				return @__env.CallIntMethod(this, _findIndexOfValue5698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.ListPreference.staticClass, _findIndexOfValue5698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ListPreference5699; 
		public ListPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.ListPreference.staticClass, _ListPreference5699, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ListPreference5700; 
		public ListPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.ListPreference.staticClass, _ListPreference5700, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.ListPreference.staticClass = @__class; 
			global::android.preference.ListPreference._getValue5682 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getValue", "()Ljava/lang/String;"); 
			global::android.preference.ListPreference._getEntry5683 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getEntry", "()Ljava/lang/CharSequence;"); 
			global::android.preference.ListPreference._setValue5684 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setValue", "(Ljava/lang/String;)V"); 
			global::android.preference.ListPreference._getEntries5685 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getEntries", "()[Ljava/lang/CharSequence;"); 
			global::android.preference.ListPreference._onRestoreInstanceState5686 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.ListPreference._onSaveInstanceState5687 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.ListPreference._onGetDefaultValue5688 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.ListPreference._onSetInitialValue5689 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.ListPreference._onPrepareDialogBuilder5690 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V"); 
			global::android.preference.ListPreference._onDialogClosed5691 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "onDialogClosed", "(Z)V"); 
			global::android.preference.ListPreference._setEntries5692 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntries", "([Ljava/lang/CharSequence;)V"); 
			global::android.preference.ListPreference._setEntries5693 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntries", "(I)V"); 
			global::android.preference.ListPreference._setEntryValues5694 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntryValues", "([Ljava/lang/CharSequence;)V"); 
			global::android.preference.ListPreference._setEntryValues5695 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setEntryValues", "(I)V"); 
			global::android.preference.ListPreference._getEntryValues5696 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "getEntryValues", "()[Ljava/lang/CharSequence;"); 
			global::android.preference.ListPreference._setValueIndex5697 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "setValueIndex", "(I)V"); 
			global::android.preference.ListPreference._findIndexOfValue5698 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "findIndexOfValue", "(Ljava/lang/String;)I"); 
			global::android.preference.ListPreference._ListPreference5699 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.preference.ListPreference._ListPreference5700 = @__env.GetMethodID(global::android.preference.ListPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
