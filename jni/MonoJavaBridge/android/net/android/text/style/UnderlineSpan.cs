namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class UnderlineSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static UnderlineSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.UnderlineSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.UnderlineSpan(@__env); 
			} 
		} 
		protected UnderlineSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7089; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.UnderlineSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.UnderlineSpan.staticClass, _writeToParcel7089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7090; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.UnderlineSpan)) 
				return @__env.CallIntMethod(this, _describeContents7090); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.UnderlineSpan.staticClass, _describeContents7090); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7091; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.UnderlineSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7091); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.UnderlineSpan.staticClass, _getSpanTypeId7091); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7092; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.UnderlineSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.UnderlineSpan.staticClass, _updateDrawState7092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UnderlineSpan7093; 
		public UnderlineSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.UnderlineSpan.staticClass, _UnderlineSpan7093, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UnderlineSpan7094; 
		public UnderlineSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.UnderlineSpan.staticClass, _UnderlineSpan7094, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.UnderlineSpan.staticClass = @__class; 
			global::android.text.style.UnderlineSpan._writeToParcel7089 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.UnderlineSpan._describeContents7090 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.UnderlineSpan._getSpanTypeId7091 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.UnderlineSpan._updateDrawState7092 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.UnderlineSpan._UnderlineSpan7093 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "<init>", "()V"); 
			global::android.text.style.UnderlineSpan._UnderlineSpan7094 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
