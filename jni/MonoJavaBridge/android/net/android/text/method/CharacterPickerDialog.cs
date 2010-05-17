namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CharacterPickerDialog : android.app.Dialog, android.widget.AdapterView.OnItemClickListener, android.view.View.OnClickListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CharacterPickerDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.CharacterPickerDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.CharacterPickerDialog(@__env); 
			} 
		} 
		protected CharacterPickerDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick6769; 
		public virtual void onClick(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.CharacterPickerDialog)) 
				@__env.CallVoidMethod(this, _onClick6769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.CharacterPickerDialog.staticClass, _onClick6769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate6770; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.CharacterPickerDialog)) 
				@__env.CallVoidMethod(this, _onCreate6770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.CharacterPickerDialog.staticClass, _onCreate6770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onItemClick6771; 
		public virtual void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.CharacterPickerDialog)) 
				@__env.CallVoidMethod(this, _onItemClick6771, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.CharacterPickerDialog.staticClass, _onItemClick6771, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharacterPickerDialog6772; 
		public CharacterPickerDialog(android.content.Context arg0, android.view.View arg1, android.text.Editable arg2, java.lang.String arg3, bool arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.CharacterPickerDialog.staticClass, _CharacterPickerDialog6772, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.CharacterPickerDialog.staticClass = @__class; 
			global::android.text.method.CharacterPickerDialog._onClick6769 = @__env.GetMethodID(global::android.text.method.CharacterPickerDialog.staticClass, "onClick", "(Landroid/view/View;)V"); 
			global::android.text.method.CharacterPickerDialog._onCreate6770 = @__env.GetMethodID(global::android.text.method.CharacterPickerDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.text.method.CharacterPickerDialog._onItemClick6771 = @__env.GetMethodID(global::android.text.method.CharacterPickerDialog.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"); 
			global::android.text.method.CharacterPickerDialog._CharacterPickerDialog6772 = @__env.GetMethodID(global::android.text.method.CharacterPickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/View;Landroid/text/Editable;Ljava/lang/String;Z)V"); 
		} 
	} 
} 
