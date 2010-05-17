namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SuperscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SuperscriptSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.SuperscriptSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.SuperscriptSpan(@__env); 
			} 
		} 
		protected SuperscriptSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7051; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SuperscriptSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7051, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.SuperscriptSpan.staticClass, _writeToParcel7051, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7052; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SuperscriptSpan)) 
				return @__env.CallIntMethod(this, _describeContents7052); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.SuperscriptSpan.staticClass, _describeContents7052); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7053; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SuperscriptSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7053); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.SuperscriptSpan.staticClass, _getSpanTypeId7053); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7054; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SuperscriptSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.SuperscriptSpan.staticClass, _updateDrawState7054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7055; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SuperscriptSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.SuperscriptSpan.staticClass, _updateMeasureState7055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SuperscriptSpan7056; 
		public SuperscriptSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.SuperscriptSpan.staticClass, _SuperscriptSpan7056, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SuperscriptSpan7057; 
		public SuperscriptSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.SuperscriptSpan.staticClass, _SuperscriptSpan7057, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.SuperscriptSpan.staticClass = @__class; 
			global::android.text.style.SuperscriptSpan._writeToParcel7051 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.SuperscriptSpan._describeContents7052 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.SuperscriptSpan._getSpanTypeId7053 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.SuperscriptSpan._updateDrawState7054 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.SuperscriptSpan._updateMeasureState7055 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.SuperscriptSpan._SuperscriptSpan7056 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "()V"); 
			global::android.text.style.SuperscriptSpan._SuperscriptSpan7057 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
