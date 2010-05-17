namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DialogPreference : android.preference.Preference, android.content.DialogInterface_OnClickListener, android.content.DialogInterface_OnDismissListener, android.preference.PreferenceManager.OnActivityDestroyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DialogPreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.DialogPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DialogPreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick5637; 
		protected override void onClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onClick5637); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onClick5637); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick5638; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onClick5638, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onClick5638, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5639; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState5639, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onRestoreInstanceState5639, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5640; 
		protected override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState5640)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _onSaveInstanceState5640)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showDialog5641; 
		protected virtual void showDialog(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _showDialog5641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _showDialog5641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss5642; 
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onDismiss5642, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onDismiss5642, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogTitle5643; 
		public virtual void setDialogTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogTitle5643, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogTitle5643, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogTitle5644; 
		public virtual void setDialogTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogTitle5644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogTitle5644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogTitle5645; 
		public virtual java.lang.CharSequence getDialogTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getDialogTitle5645)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _getDialogTitle5645)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogMessage5646; 
		public virtual void setDialogMessage(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogMessage5646, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogMessage5646, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogMessage5647; 
		public virtual void setDialogMessage(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogMessage5647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogMessage5647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogMessage5648; 
		public virtual java.lang.CharSequence getDialogMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getDialogMessage5648)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _getDialogMessage5648)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogIcon5649; 
		public virtual void setDialogIcon(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogIcon5649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogIcon5649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogIcon5650; 
		public virtual void setDialogIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogIcon5650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogIcon5650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogIcon5651; 
		public virtual android.graphics.drawable.Drawable getDialogIcon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDialogIcon5651)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _getDialogIcon5651)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositiveButtonText5652; 
		public virtual void setPositiveButtonText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setPositiveButtonText5652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setPositiveButtonText5652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositiveButtonText5653; 
		public virtual void setPositiveButtonText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setPositiveButtonText5653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setPositiveButtonText5653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositiveButtonText5654; 
		public virtual java.lang.CharSequence getPositiveButtonText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getPositiveButtonText5654)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _getPositiveButtonText5654)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNegativeButtonText5655; 
		public virtual void setNegativeButtonText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setNegativeButtonText5655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setNegativeButtonText5655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNegativeButtonText5656; 
		public virtual void setNegativeButtonText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setNegativeButtonText5656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setNegativeButtonText5656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNegativeButtonText5657; 
		public virtual java.lang.CharSequence getNegativeButtonText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getNegativeButtonText5657)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _getNegativeButtonText5657)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDialogLayoutResource5658; 
		public virtual void setDialogLayoutResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _setDialogLayoutResource5658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _setDialogLayoutResource5658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialogLayoutResource5659; 
		public virtual int getDialogLayoutResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return @__env.CallIntMethod(this, _getDialogLayoutResource5659); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.preference.DialogPreference.staticClass, _getDialogLayoutResource5659); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialogBuilder5660; 
		protected virtual void onPrepareDialogBuilder(android.app.AlertDialog.Builder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onPrepareDialogBuilder5660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onPrepareDialogBuilder5660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialogView5661; 
		protected virtual android.view.View onCreateDialogView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateDialogView5661)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _onCreateDialogView5661)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindDialogView5662; 
		protected virtual void onBindDialogView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onBindDialogView5662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onBindDialogView5662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed5663; 
		protected virtual void onDialogClosed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onDialogClosed5663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onDialogClosed5663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialog5664; 
		public virtual android.app.Dialog getDialog() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, _getDialog5664)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.DialogPreference.staticClass, _getDialog5664)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityDestroy5665; 
		public virtual void onActivityDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.DialogPreference)) 
				@__env.CallVoidMethod(this, _onActivityDestroy5665); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.DialogPreference.staticClass, _onActivityDestroy5665); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialogPreference5666; 
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.DialogPreference.staticClass, _DialogPreference5666, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialogPreference5667; 
		public DialogPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.DialogPreference.staticClass, _DialogPreference5667, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.DialogPreference.staticClass = @__class; 
			global::android.preference.DialogPreference._onClick5637 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onClick", "()V"); 
			global::android.preference.DialogPreference._onClick5638 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.preference.DialogPreference._onRestoreInstanceState5639 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.DialogPreference._onSaveInstanceState5640 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.DialogPreference._showDialog5641 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "showDialog", "(Landroid/os/Bundle;)V"); 
			global::android.preference.DialogPreference._onDismiss5642 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V"); 
			global::android.preference.DialogPreference._setDialogTitle5643 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._setDialogTitle5644 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogTitle", "(I)V"); 
			global::android.preference.DialogPreference._getDialogTitle5645 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogTitle", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setDialogMessage5646 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._setDialogMessage5647 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogMessage", "(I)V"); 
			global::android.preference.DialogPreference._getDialogMessage5648 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogMessage", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setDialogIcon5649 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.preference.DialogPreference._setDialogIcon5650 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogIcon", "(I)V"); 
			global::android.preference.DialogPreference._getDialogIcon5651 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogIcon", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.preference.DialogPreference._setPositiveButtonText5652 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(I)V"); 
			global::android.preference.DialogPreference._setPositiveButtonText5653 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setPositiveButtonText", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._getPositiveButtonText5654 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getPositiveButtonText", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setNegativeButtonText5655 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(I)V"); 
			global::android.preference.DialogPreference._setNegativeButtonText5656 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setNegativeButtonText", "(Ljava/lang/CharSequence;)V"); 
			global::android.preference.DialogPreference._getNegativeButtonText5657 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getNegativeButtonText", "()Ljava/lang/CharSequence;"); 
			global::android.preference.DialogPreference._setDialogLayoutResource5658 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "setDialogLayoutResource", "(I)V"); 
			global::android.preference.DialogPreference._getDialogLayoutResource5659 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialogLayoutResource", "()I"); 
			global::android.preference.DialogPreference._onPrepareDialogBuilder5660 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V"); 
			global::android.preference.DialogPreference._onCreateDialogView5661 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onCreateDialogView", "()Landroid/view/View;"); 
			global::android.preference.DialogPreference._onBindDialogView5662 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V"); 
			global::android.preference.DialogPreference._onDialogClosed5663 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onDialogClosed", "(Z)V"); 
			global::android.preference.DialogPreference._getDialog5664 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "getDialog", "()Landroid/app/Dialog;"); 
			global::android.preference.DialogPreference._onActivityDestroy5665 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "onActivityDestroy", "()V"); 
			global::android.preference.DialogPreference._DialogPreference5666 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.DialogPreference._DialogPreference5667 = @__env.GetMethodID(global::android.preference.DialogPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
