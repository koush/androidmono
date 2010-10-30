namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ContentValues : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentValues(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Object get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.content.ContentValues._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void put(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.ContentValues._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void put(java.lang.String arg0, java.lang.Byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V", ref global::android.content.ContentValues._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void put(java.lang.String arg0, java.lang.Short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V", ref global::android.content.ContentValues._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void put(java.lang.String arg0, java.lang.Integer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V", ref global::android.content.ContentValues._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void put(java.lang.String arg0, java.lang.Long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V", ref global::android.content.ContentValues._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void put(java.lang.String arg0, java.lang.Boolean arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V", ref global::android.content.ContentValues._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void put(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V", ref global::android.content.ContentValues._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void put(java.lang.String arg0, java.lang.Float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V", ref global::android.content.ContentValues._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void put(java.lang.String arg0, java.lang.Double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V", ref global::android.content.ContentValues._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.ContentValues._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.ContentValues._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentValues.staticClass, "hashCode", "()I", ref global::android.content.ContentValues._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "clear", "()V", ref global::android.content.ContentValues._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentValues.staticClass, "size", "()I", ref global::android.content.ContentValues._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public void putAll(android.content.ContentValues arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V", ref global::android.content.ContentValues._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V", ref global::android.content.ContentValues._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public bool containsKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z", ref global::android.content.ContentValues._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::java.lang.String getAsString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.ContentValues._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void putNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V", ref global::android.content.ContentValues._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.ContentValues._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentValues.staticClass, "describeContents", "()I", ref global::android.content.ContentValues._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.lang.Long getAsLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Long>(this, global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;", ref global::android.content.ContentValues._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public global::java.lang.Integer getAsInteger(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Integer>(this, global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", ref global::android.content.ContentValues._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.lang.Short getAsShort(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Short>(this, global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;", ref global::android.content.ContentValues._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Short;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public global::java.lang.Byte getAsByte(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Byte>(this, global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;", ref global::android.content.ContentValues._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Byte;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public global::java.lang.Double getAsDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Double>(this, global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;", ref global::android.content.ContentValues._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Double;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public global::java.lang.Float getAsFloat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Float>(this, global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;", ref global::android.content.ContentValues._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Float;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public global::java.lang.Boolean getAsBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Boolean>(this, global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", ref global::android.content.ContentValues._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Boolean;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public byte[] getAsByteArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B", ref global::android.content.ContentValues._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public global::java.util.Set valueSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;", ref global::android.content.ContentValues._m30) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public ContentValues() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentValues._m31.native == global::System.IntPtr.Zero)
				global::android.content.ContentValues._m31 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._m31);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public ContentValues(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentValues._m32.native == global::System.IntPtr.Zero)
				global::android.content.ContentValues._m32 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public ContentValues(android.content.ContentValues arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentValues._m33.native == global::System.IntPtr.Zero)
				global::android.content.ContentValues._m33 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TAG
		{
			get
			{
				return "ContentValues";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1641;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentValues.staticClass, _CREATOR1641)) as android.os.Parcelable_Creator;
			}
		}
		static ContentValues()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentValues"));
			global::android.content.ContentValues._CREATOR1641 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentValues.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
