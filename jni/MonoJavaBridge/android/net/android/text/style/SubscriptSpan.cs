namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SubscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SubscriptSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.SubscriptSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.SubscriptSpan(@__env); 
			} 
		} 
		protected SubscriptSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7044; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SubscriptSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.SubscriptSpan.staticClass, _writeToParcel7044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7045; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SubscriptSpan)) 
				return @__env.CallIntMethod(this, _describeContents7045); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.SubscriptSpan.staticClass, _describeContents7045); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7046; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SubscriptSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7046); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.SubscriptSpan.staticClass, _getSpanTypeId7046); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7047; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SubscriptSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.SubscriptSpan.staticClass, _updateDrawState7047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7048; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.SubscriptSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.SubscriptSpan.staticClass, _updateMeasureState7048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SubscriptSpan7049; 
		public SubscriptSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.SubscriptSpan.staticClass, _SubscriptSpan7049, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SubscriptSpan7050; 
		public SubscriptSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.SubscriptSpan.staticClass, _SubscriptSpan7050, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.SubscriptSpan.staticClass = @__class; 
			global::android.text.style.SubscriptSpan._writeToParcel7044 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.SubscriptSpan._describeContents7045 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.SubscriptSpan._getSpanTypeId7046 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.SubscriptSpan._updateDrawState7047 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.SubscriptSpan._updateMeasureState7048 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.SubscriptSpan._SubscriptSpan7049 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "<init>", "()V"); 
			global::android.text.style.SubscriptSpan._SubscriptSpan7050 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
