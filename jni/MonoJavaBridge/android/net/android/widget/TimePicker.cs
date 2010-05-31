namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimePicker : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TimePicker() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TimePicker), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class OnTimeChangedListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnTimeChangedListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnTimeChangedListener : java.lang.Object, OnTimeChangedListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnTimeChangedListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TimePicker.__OnTimeChangedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TimePicker.__OnTimeChangedListener(@__env); 
				} 
			} 
			internal __OnTimeChangedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTimeChanged11214; 
			 void android.widget.TimePicker.OnTimeChangedListener.onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.widget.TimePicker.__OnTimeChangedListener._onTimeChanged11214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.__OnTimeChangedListener.staticClass, global::android.widget.TimePicker.__OnTimeChangedListener._onTimeChanged11214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TimePicker.__OnTimeChangedListener.staticClass = @__class; 
				global::android.widget.TimePicker.__OnTimeChangedListener._onTimeChanged11214 = @__env.GetMethodID(global::android.widget.TimePicker.__OnTimeChangedListener.staticClass, "android.widget.TimePicker.OnTimeChangedListener.onTimeChanged", "(Landroid/widget/TimePicker;II)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled11215; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TimePicker._setEnabled11215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setEnabled11215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState11216; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TimePicker._onRestoreInstanceState11216, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onRestoreInstanceState11216, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState11217; 
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TimePicker._onSaveInstanceState11217)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onSaveInstanceState11217)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline11218; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TimePicker._getBaseline11218); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getBaseline11218); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _is24HourView11219; 
		public virtual bool is24HourView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TimePicker._is24HourView11219); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._is24HourView11219); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnTimeChangedListener11220; 
		public virtual void setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TimePicker._setOnTimeChangedListener11220, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setOnTimeChangedListener11220, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentHour11221; 
		public virtual global::java.lang.Integer getCurrentHour() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TimePicker._getCurrentHour11221)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentHour11221)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentHour11222; 
		public virtual void setCurrentHour(java.lang.Integer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TimePicker._setCurrentHour11222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentHour11222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIs24HourView11223; 
		public virtual void setIs24HourView(java.lang.Boolean arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TimePicker._setIs24HourView11223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setIs24HourView11223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentMinute11224; 
		public virtual global::java.lang.Integer getCurrentMinute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TimePicker._getCurrentMinute11224)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentMinute11224)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentMinute11225; 
		public virtual void setCurrentMinute(java.lang.Integer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TimePicker._setCurrentMinute11225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentMinute11225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePicker11226; 
		public TimePicker(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker11226, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePicker11227; 
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker11227, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePicker11228; 
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker11228, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TimePicker.staticClass = @__class; 
			global::android.widget.TimePicker._setEnabled11215 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.TimePicker._onRestoreInstanceState11216 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.TimePicker._onSaveInstanceState11217 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.TimePicker._getBaseline11218 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "getBaseline", "()I"); 
			global::android.widget.TimePicker._is24HourView11219 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "is24HourView", "()Z"); 
			global::android.widget.TimePicker._setOnTimeChangedListener11220 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V"); 
			global::android.widget.TimePicker._getCurrentHour11221 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "getCurrentHour", "()Ljava/lang/Integer;"); 
			global::android.widget.TimePicker._setCurrentHour11222 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setCurrentHour", "(Ljava/lang/Integer;)V"); 
			global::android.widget.TimePicker._setIs24HourView11223 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setIs24HourView", "(Ljava/lang/Boolean;)V"); 
			global::android.widget.TimePicker._getCurrentMinute11224 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "getCurrentMinute", "()Ljava/lang/Integer;"); 
			global::android.widget.TimePicker._setCurrentMinute11225 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "setCurrentMinute", "(Ljava/lang/Integer;)V"); 
			global::android.widget.TimePicker._TimePicker11226 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TimePicker._TimePicker11227 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TimePicker._TimePicker11228 = @__env.GetMethodID(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
