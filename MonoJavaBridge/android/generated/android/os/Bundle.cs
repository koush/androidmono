namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bundle : java.lang.Object, Parcelable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Bundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get9595;
		public global::java.lang.Object get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.os.Bundle._get9595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString9596;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.Bundle._toString9596) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone9597;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.os.Bundle._clone9597) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean9598;
		public bool getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::android.os.Bundle._getBoolean9598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean9599;
		public bool getBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z", ref global::android.os.Bundle._getBoolean9599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean9600;
		public void putBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V", ref global::android.os.Bundle._putBoolean9600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByte9601;
		public byte getByte(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B", ref global::android.os.Bundle._getByte9601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte9602;
		public global::java.lang.Byte getByte(java.lang.String arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Byte>(this, global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;", ref global::android.os.Bundle._getByte9602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _putByte9603;
		public void putByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V", ref global::android.os.Bundle._putByte9603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort9604;
		public short getShort(java.lang.String arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S", ref global::android.os.Bundle._getShort9604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort9605;
		public short getShort(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S", ref global::android.os.Bundle._getShort9605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putShort9606;
		public void putShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V", ref global::android.os.Bundle._putShort9606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChar9607;
		public char getChar(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C", ref global::android.os.Bundle._getChar9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar9608;
		public char getChar(java.lang.String arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C", ref global::android.os.Bundle._getChar9608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putChar9609;
		public void putChar(java.lang.String arg0, char arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V", ref global::android.os.Bundle._putChar9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt9610;
		public int getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::android.os.Bundle._getInt9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt9611;
		public int getInt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::android.os.Bundle._getInt9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt9612;
		public void putInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V", ref global::android.os.Bundle._putInt9612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong9613;
		public long getLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J", ref global::android.os.Bundle._getLong9613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong9614;
		public long getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::android.os.Bundle._getLong9614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong9615;
		public void putLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V", ref global::android.os.Bundle._putLong9615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat9616;
		public float getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::android.os.Bundle._getFloat9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat9617;
		public float getFloat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F", ref global::android.os.Bundle._getFloat9617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat9618;
		public void putFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V", ref global::android.os.Bundle._putFloat9618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble9619;
		public double getDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D", ref global::android.os.Bundle._getDouble9619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble9620;
		public double getDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D", ref global::android.os.Bundle._getDouble9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble9621;
		public void putDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V", ref global::android.os.Bundle._putDouble9621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear9622;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "clear", "()V", ref global::android.os.Bundle._clear9622);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty9623;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "isEmpty", "()Z", ref global::android.os.Bundle._isEmpty9623);
		}
		internal static global::MonoJavaBridge.MethodId _size9624;
		public int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "size", "()I", ref global::android.os.Bundle._size9624);
		}
		internal static global::MonoJavaBridge.MethodId _putAll9625;
		public void putAll(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V", ref global::android.os.Bundle._putAll9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove9626;
		public void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V", ref global::android.os.Bundle._remove9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keySet9627;
		public global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;", ref global::android.os.Bundle._keySet9627) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsKey9628;
		public bool containsKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z", ref global::android.os.Bundle._containsKey9628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBundle9629;
		public global::android.os.Bundle getBundle(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", ref global::android.os.Bundle._getBundle9629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getString9630;
		public global::java.lang.String getString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.os.Bundle._getString9630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9631;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.Bundle._writeToParcel9631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9632;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Bundle.staticClass, "describeContents", "()I", ref global::android.os.Bundle._describeContents9632);
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors9633;
		public bool hasFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z", ref global::android.os.Bundle._hasFileDescriptors9633);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel9634;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.os.Bundle._readFromParcel9634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray9635;
		public global::java.lang.String[] getStringArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::android.os.Bundle._getStringArray9635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray9636;
		public int[] getIntArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I", ref global::android.os.Bundle._getIntArray9636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			set
			{
				setClassLoader(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setClassLoader9637;
		public void setClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V", ref global::android.os.Bundle._setClassLoader9637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putString9638;
		public void putString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.os.Bundle._putString9638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequence9639;
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V", ref global::android.os.Bundle._putCharSequence9639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void putCharSequence(java.lang.String arg0, string arg1)
		{
			putCharSequence(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _putParcelable9640;
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V", ref global::android.os.Bundle._putParcelable9640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArray9641;
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V", ref global::android.os.Bundle._putParcelableArray9641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArrayList9642;
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._putParcelableArrayList9642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putSparseParcelableArray9643;
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V", ref global::android.os.Bundle._putSparseParcelableArray9643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIntegerArrayList9644;
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._putIntegerArrayList9644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putStringArrayList9645;
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._putStringArrayList9645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArrayList9646;
		public void putCharSequenceArrayList(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", ref global::android.os.Bundle._putCharSequenceArrayList9646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putSerializable9647;
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V", ref global::android.os.Bundle._putSerializable9647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBooleanArray9648;
		public void putBooleanArray(java.lang.String arg0, bool[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V", ref global::android.os.Bundle._putBooleanArray9648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray9649;
		public void putByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V", ref global::android.os.Bundle._putByteArray9649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putShortArray9650;
		public void putShortArray(java.lang.String arg0, short[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V", ref global::android.os.Bundle._putShortArray9650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharArray9651;
		public void putCharArray(java.lang.String arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V", ref global::android.os.Bundle._putCharArray9651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIntArray9652;
		public void putIntArray(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V", ref global::android.os.Bundle._putIntArray9652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLongArray9653;
		public void putLongArray(java.lang.String arg0, long[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V", ref global::android.os.Bundle._putLongArray9653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloatArray9654;
		public void putFloatArray(java.lang.String arg0, float[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V", ref global::android.os.Bundle._putFloatArray9654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDoubleArray9655;
		public void putDoubleArray(java.lang.String arg0, double[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V", ref global::android.os.Bundle._putDoubleArray9655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putStringArray9656;
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V", ref global::android.os.Bundle._putStringArray9656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArray9657;
		public void putCharSequenceArray(java.lang.String arg0, java.lang.CharSequence[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V", ref global::android.os.Bundle._putCharSequenceArray9657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBundle9658;
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.os.Bundle._putBundle9658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequence9659;
		public global::java.lang.CharSequence getCharSequence(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;", ref global::android.os.Bundle._getCharSequence9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelable9660;
		public global::android.os.Parcelable getParcelable(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;", ref global::android.os.Bundle._getParcelable9660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArray9661;
		public global::android.os.Parcelable[] getParcelableArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.Parcelable>(this, global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;", ref global::android.os.Bundle._getParcelableArray9661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayList9662;
		public global::java.util.ArrayList getParcelableArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._getParcelableArrayList9662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getSparseParcelableArray9663;
		public global::android.util.SparseArray getSparseParcelableArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;", ref global::android.os.Bundle._getSparseParcelableArray9663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.util.SparseArray;
		}
		internal static global::MonoJavaBridge.MethodId _getSerializable9664;
		public global::java.io.Serializable getSerializable(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.io.Serializable>(this, global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;", ref global::android.os.Bundle._getSerializable9664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerArrayList9665;
		public global::java.util.ArrayList getIntegerArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._getIntegerArrayList9665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayList9666;
		public global::java.util.ArrayList getStringArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._getStringArrayList9666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayList9667;
		public global::java.util.ArrayList getCharSequenceArrayList(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Bundle.staticClass, "getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.os.Bundle._getCharSequenceArrayList9667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanArray9668;
		public bool[] getBooleanArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z", ref global::android.os.Bundle._getBooleanArray9668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray9669;
		public byte[] getByteArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B", ref global::android.os.Bundle._getByteArray9669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getShortArray9670;
		public short[] getShortArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<short>(this, global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S", ref global::android.os.Bundle._getShortArray9670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharArray9671;
		public char[] getCharArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C", ref global::android.os.Bundle._getCharArray9671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getLongArray9672;
		public long[] getLongArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J", ref global::android.os.Bundle._getLongArray9672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _getFloatArray9673;
		public float[] getFloatArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F", ref global::android.os.Bundle._getFloatArray9673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleArray9674;
		public double[] getDoubleArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<double>(this, global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D", ref global::android.os.Bundle._getDoubleArray9674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArray9675;
		public global::java.lang.CharSequence[] getCharSequenceArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.os.Bundle.staticClass, "getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", ref global::android.os.Bundle._getCharSequenceArray9675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9676;
		public Bundle(android.os.Bundle arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._Bundle9676.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._Bundle9676 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9677;
		public Bundle(java.lang.ClassLoader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._Bundle9677.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._Bundle9677 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9678;
		public Bundle(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._Bundle9678.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._Bundle9678 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9679;
		public Bundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Bundle._Bundle9679.native == global::System.IntPtr.Zero)
				global::android.os.Bundle._Bundle9679 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9679);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY9680;
		public static global::android.os.Bundle EMPTY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetStaticObjectField(global::android.os.Bundle.staticClass, _EMPTY9680)) as android.os.Bundle;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR9681;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Bundle.staticClass, _CREATOR9681)) as android.os.Parcelable_Creator;
			}
		}
		static Bundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Bundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Bundle"));
			global::android.os.Bundle._EMPTY9680 = @__env.GetStaticFieldIDNoThrow(global::android.os.Bundle.staticClass, "EMPTY", "Landroid/os/Bundle;");
			global::android.os.Bundle._CREATOR9681 = @__env.GetStaticFieldIDNoThrow(global::android.os.Bundle.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
