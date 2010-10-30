namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bundle : java.lang.Object, Parcelable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Bundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Object get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.os.Bundle._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.Bundle._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.os.Bundle._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public bool getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::android.os.Bundle._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool getBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z", ref global::android.os.Bundle._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void putBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V", ref global::android.os.Bundle._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public byte getByte(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B", ref global::android.os.Bundle._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.Byte getByte(java.lang.String arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Byte>(this, global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;", ref global::android.os.Bundle._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Byte;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void putByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V", ref global::android.os.Bundle._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public short getShort(java.lang.String arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S", ref global::android.os.Bundle._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public short getShort(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S", ref global::android.os.Bundle._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void putShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V", ref global::android.os.Bundle._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public char getChar(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C", ref global::android.os.Bundle._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public char getChar(java.lang.String arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C", ref global::android.os.Bundle._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public void putChar(java.lang.String arg0, char arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V", ref global::android.os.Bundle._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public int getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::android.os.Bundle._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public int getInt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::android.os.Bundle._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void putInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V", ref global::android.os.Bundle._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public long getLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J", ref global::android.os.Bundle._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public long getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::android.os.Bundle._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public void putLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V", ref global::android.os.Bundle._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public float getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::android.os.Bundle._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public float getFloat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F", ref global::android.os.Bundle._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public void putFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V", ref global::android.os.Bundle._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public double getDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D", ref global::android.os.Bundle._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public double getDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D", ref global::android.os.Bundle._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public void putDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V", ref global::android.os.Bundle._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "clear", "()V", ref global::android.os.Bundle._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "isEmpty", "()Z", ref global::android.os.Bundle._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "size", "()I", ref global::android.os.Bundle._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public void putAll(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V", ref global::android.os.Bundle._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V", ref global::android.os.Bundle._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;", ref global::android.os.Bundle._m32) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public bool containsKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z", ref global::android.os.Bundle._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public global::android.os.Bundle getBundle(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", ref global::android.os.Bundle._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public global::java.lang.String getString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.os.Bundle._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.Bundle._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "describeContents", "()I", ref global::android.os.Bundle._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public bool hasFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z", ref global::android.os.Bundle._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.os.Bundle._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public global::java.lang.String[] getStringArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::android.os.Bundle._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public int[] getIntArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I", ref global::android.os.Bundle._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			set
			{
				setClassLoader(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public void setClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V", ref global::android.os.Bundle._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public void putString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.os.Bundle._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V", ref global::android.os.Bundle._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void putCharSequence(java.lang.String arg0, string arg1)
		{
			putCharSequence(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V", ref global::android.os.Bundle._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V", ref global::android.os.Bundle._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V", ref global::android.os.Bundle._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public void putCharSequenceArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V", ref global::android.os.Bundle._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public void putBooleanArray(java.lang.String arg0, bool[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V", ref global::android.os.Bundle._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public void putByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V", ref global::android.os.Bundle._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public void putShortArray(java.lang.String arg0, short[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V", ref global::android.os.Bundle._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public void putCharArray(java.lang.String arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V", ref global::android.os.Bundle._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public void putIntArray(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V", ref global::android.os.Bundle._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public void putLongArray(java.lang.String arg0, long[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V", ref global::android.os.Bundle._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public void putFloatArray(java.lang.String arg0, float[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V", ref global::android.os.Bundle._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public void putDoubleArray(java.lang.String arg0, double[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V", ref global::android.os.Bundle._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V", ref global::android.os.Bundle._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public void putCharSequenceArray(java.lang.String arg0, java.lang.CharSequence[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V", ref global::android.os.Bundle._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.os.Bundle._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public global::java.lang.CharSequence getCharSequence(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;", ref global::android.os.Bundle._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public global::android.os.Parcelable getParcelable(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;", ref global::android.os.Bundle._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public global::android.os.Parcelable[] getParcelableArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.Parcelable>(this, global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;", ref global::android.os.Bundle._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable[];
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public global::java.util.ArrayList getParcelableArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public global::android.util.SparseArray getSparseParcelableArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;", ref global::android.os.Bundle._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.util.SparseArray;
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public global::java.io.Serializable getSerializable(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.io.Serializable>(this, global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;", ref global::android.os.Bundle._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Serializable;
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public global::java.util.ArrayList getIntegerArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public global::java.util.ArrayList getStringArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public global::java.util.ArrayList getCharSequenceArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public bool[] getBooleanArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z", ref global::android.os.Bundle._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public byte[] getByteArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B", ref global::android.os.Bundle._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public short[] getShortArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<short>(this, global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S", ref global::android.os.Bundle._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as short[];
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public char[] getCharArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C", ref global::android.os.Bundle._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public long[] getLongArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J", ref global::android.os.Bundle._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as long[];
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public float[] getFloatArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F", ref global::android.os.Bundle._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public double[] getDoubleArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<double>(this, global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D", ref global::android.os.Bundle._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as double[];
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public global::java.lang.CharSequence[] getCharSequenceArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.os.Bundle.staticClass, "getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", ref global::android.os.Bundle._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public Bundle(android.os.Bundle arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._m81.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._m81 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public Bundle(java.lang.ClassLoader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._m82.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._m82 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public Bundle(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._m83.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._m83 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public Bundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._m84.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._m84 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._m84);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY3946;
		public static global::android.os.Bundle EMPTY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetStaticObjectField(global::android.os.Bundle.staticClass, _EMPTY3946)) as android.os.Bundle;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3947;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Bundle.staticClass, _CREATOR3947)) as android.os.Parcelable_Creator;
			}
		}
		static Bundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Bundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Bundle"));
			global::android.os.Bundle._EMPTY3946 = @__env.GetStaticFieldIDNoThrow(global::android.os.Bundle.staticClass, "EMPTY", "Landroid/os/Bundle;");
			global::android.os.Bundle._CREATOR3947 = @__env.GetStaticFieldIDNoThrow(global::android.os.Bundle.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
