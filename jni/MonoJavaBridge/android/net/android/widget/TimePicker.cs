namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimePicker : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TimePicker() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TimePicker), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TimePicker(@__env); 
			} 
		} 
		protected TimePicker(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTimeChangedListener 
		{ 
			void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled10410; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				@__env.CallVoidMethod(this, _setEnabled10410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TimePicker.staticClass, _setEnabled10410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10411; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState10411, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TimePicker.staticClass, _onRestoreInstanceState10411, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10412; 
		protected override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState10412)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TimePicker.staticClass, _onSaveInstanceState10412)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10413; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				return @__env.CallIntMethod(this, _getBaseline10413); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TimePicker.staticClass, _getBaseline10413); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _is24HourView10414; 
		public virtual bool is24HourView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				return @__env.CallBooleanMethod(this, _is24HourView10414); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TimePicker.staticClass, _is24HourView10414); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnTimeChangedListener10415; 
		public virtual void setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				@__env.CallVoidMethod(this, _setOnTimeChangedListener10415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TimePicker.staticClass, _setOnTimeChangedListener10415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentHour10416; 
		public virtual java.lang.Integer getCurrentHour() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentHour10416)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TimePicker.staticClass, _getCurrentHour10416)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentHour10417; 
		public virtual void setCurrentHour(java.lang.Integer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				@__env.CallVoidMethod(this, _setCurrentHour10417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TimePicker.staticClass, _setCurrentHour10417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIs24HourView10418; 
		public virtual void setIs24HourView(java.lang.Boolean arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				@__env.CallVoidMethod(this, _setIs24HourView10418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TimePicker.staticClass, _setIs24HourView10418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentMinute10419; 
		public virtual java.lang.Integer getCurrentMinute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentMinute10419)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TimePicker.staticClass, _getCurrentMinute10419)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentMinute10420; 
		public virtual void setCurrentMinute(java.lang.Integer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TimePicker)) 
				@__env.CallVoidMethod(this, _setCurrentMinute10420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TimePicker.staticClass, _setCurrentMinute10420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePicker10421; 
		public TimePicker(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TimePicker.staticClass, _TimePicker10421, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePicker10422; 
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TimePicker.staticClass, _TimePicker10422, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePicker10423; 
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TimePicker.staticClass, _TimePicker10423, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TimePicker.staticClass = @__class; 
			global::android.widget.TimePicker._setEnabled10410 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.TimePicker._onRestoreInstanceState10411 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.TimePicker._onSaveInstanceState10412 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.TimePicker._getBaseline10413 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "getBaseline", "()I"); 
			global::android.widget.TimePicker._is24HourView10414 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "is24HourView", "()Z"); 
			global::android.widget.TimePicker._setOnTimeChangedListener10415 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V"); 
			global::android.widget.TimePicker._getCurrentHour10416 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "getCurrentHour", "()Ljava/lang/Integer;"); 
			global::android.widget.TimePicker._setCurrentHour10417 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setCurrentHour", "(Ljava/lang/Integer;)V"); 
			global::android.widget.TimePicker._setIs24HourView10418 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setIs24HourView", "(Ljava/lang/Boolean;)V"); 
			global::android.widget.TimePicker._getCurrentMinute10419 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "getCurrentMinute", "()Ljava/lang/Integer;"); 
			global::android.widget.TimePicker._setCurrentMinute10420 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setCurrentMinute", "(Ljava/lang/Integer;)V"); 
			global::android.widget.TimePicker._TimePicker10421 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TimePicker._TimePicker10422 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TimePicker._TimePicker10423 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
