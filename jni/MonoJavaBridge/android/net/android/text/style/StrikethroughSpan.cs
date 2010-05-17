namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StrikethroughSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static StrikethroughSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.StrikethroughSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.StrikethroughSpan(@__env); 
			} 
		} 
		protected StrikethroughSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7030; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StrikethroughSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StrikethroughSpan.staticClass, _writeToParcel7030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7031; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StrikethroughSpan)) 
				return @__env.CallIntMethod(this, _describeContents7031); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StrikethroughSpan.staticClass, _describeContents7031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7032; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StrikethroughSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7032); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StrikethroughSpan.staticClass, _getSpanTypeId7032); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7033; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StrikethroughSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StrikethroughSpan.staticClass, _updateDrawState7033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StrikethroughSpan7034; 
		public StrikethroughSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.StrikethroughSpan.staticClass, _StrikethroughSpan7034, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StrikethroughSpan7035; 
		public StrikethroughSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.StrikethroughSpan.staticClass, _StrikethroughSpan7035, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.StrikethroughSpan.staticClass = @__class; 
			global::android.text.style.StrikethroughSpan._writeToParcel7030 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.StrikethroughSpan._describeContents7031 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.StrikethroughSpan._getSpanTypeId7032 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.StrikethroughSpan._updateDrawState7033 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.StrikethroughSpan._StrikethroughSpan7034 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "()V"); 
			global::android.text.style.StrikethroughSpan._StrikethroughSpan7035 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
