namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DatePicker : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DatePicker() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.DatePicker), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.DatePicker(@__env); 
			} 
		} 
		protected DatePicker(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDateChangedListener 
		{ 
			void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _init9366; 
		public virtual void init(int arg0, int arg1, int arg2, android.widget.DatePicker.OnDateChangedListener arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				@__env.CallVoidMethod(this, _init9366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DatePicker.staticClass, _init9366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYear9367; 
		public virtual int getYear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				return @__env.CallIntMethod(this, _getYear9367); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.DatePicker.staticClass, _getYear9367); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMonth9368; 
		public virtual int getMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				return @__env.CallIntMethod(this, _getMonth9368); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.DatePicker.staticClass, _getMonth9368); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDayOfMonth9369; 
		public virtual int getDayOfMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				return @__env.CallIntMethod(this, _getDayOfMonth9369); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.DatePicker.staticClass, _getDayOfMonth9369); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled9370; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				@__env.CallVoidMethod(this, _setEnabled9370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DatePicker.staticClass, _setEnabled9370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9371; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState9371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DatePicker.staticClass, _onRestoreInstanceState9371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9372; 
		protected override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState9372)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.DatePicker.staticClass, _onSaveInstanceState9372)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState9373; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState9373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DatePicker.staticClass, _dispatchRestoreInstanceState9373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDate9374; 
		public virtual void updateDate(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DatePicker)) 
				@__env.CallVoidMethod(this, _updateDate9374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DatePicker.staticClass, _updateDate9374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePicker9375; 
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DatePicker.staticClass, _DatePicker9375, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePicker9376; 
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DatePicker.staticClass, _DatePicker9376, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatePicker9377; 
		public DatePicker(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DatePicker.staticClass, _DatePicker9377, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.DatePicker.staticClass = @__class; 
			global::android.widget.DatePicker._init9366 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V"); 
			global::android.widget.DatePicker._getYear9367 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "getYear", "()I"); 
			global::android.widget.DatePicker._getMonth9368 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "getMonth", "()I"); 
			global::android.widget.DatePicker._getDayOfMonth9369 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "getDayOfMonth", "()I"); 
			global::android.widget.DatePicker._setEnabled9370 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.DatePicker._onRestoreInstanceState9371 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.DatePicker._onSaveInstanceState9372 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.DatePicker._dispatchRestoreInstanceState9373 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.widget.DatePicker._updateDate9374 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "updateDate", "(III)V"); 
			global::android.widget.DatePicker._DatePicker9375 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.DatePicker._DatePicker9376 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.DatePicker._DatePicker9377 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
