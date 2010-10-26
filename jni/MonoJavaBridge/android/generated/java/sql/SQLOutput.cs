namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLOutput_))]
	public partial interface SQLOutput  : global::MonoJavaBridge.IJavaObject 
	{
		void writeObject(java.sql.SQLData arg0);
		void writeInt(int arg0);
		void writeBytes(byte[] arg0);
		void writeLong(long arg0);
		void writeByte(byte arg0);
		void writeShort(short arg0);
		void writeFloat(float arg0);
		void writeString(java.lang.String arg0);
		void writeDouble(double arg0);
		void writeArray(java.sql.Array arg0);
		void writeBoolean(bool arg0);
		void writeBigDecimal(java.math.BigDecimal arg0);
		void writeDate(java.sql.Date arg0);
		void writeTime(java.sql.Time arg0);
		void writeTimestamp(java.sql.Timestamp arg0);
		void writeCharacterStream(java.io.Reader arg0);
		void writeAsciiStream(java.io.InputStream arg0);
		void writeBinaryStream(java.io.InputStream arg0);
		void writeRef(java.sql.Ref arg0);
		void writeBlob(java.sql.Blob arg0);
		void writeClob(java.sql.Clob arg0);
		void writeStruct(java.sql.Struct arg0);
		void writeURL(java.net.URL arg0);
		void writeNString(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLOutput))]
	internal sealed partial class SQLOutput_ : java.lang.Object, SQLOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLOutput_()
		{
			InitJNI();
		}
		internal SQLOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeObject25006;
		 void java.sql.SQLOutput.writeObject(java.sql.SQLData arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeObject25006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeObject25006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt25007;
		 void java.sql.SQLOutput.writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeInt25007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeInt25007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes25008;
		 void java.sql.SQLOutput.writeBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBytes25008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBytes25008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong25009;
		 void java.sql.SQLOutput.writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeLong25009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeLong25009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte25010;
		 void java.sql.SQLOutput.writeByte(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeByte25010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeByte25010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort25011;
		 void java.sql.SQLOutput.writeShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeShort25011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeShort25011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat25012;
		 void java.sql.SQLOutput.writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeFloat25012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeFloat25012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString25013;
		 void java.sql.SQLOutput.writeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeString25013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeString25013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble25014;
		 void java.sql.SQLOutput.writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeDouble25014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeDouble25014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray25015;
		 void java.sql.SQLOutput.writeArray(java.sql.Array arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeArray25015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeArray25015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean25016;
		 void java.sql.SQLOutput.writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBoolean25016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBoolean25016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBigDecimal25017;
		 void java.sql.SQLOutput.writeBigDecimal(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBigDecimal25017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBigDecimal25017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDate25018;
		 void java.sql.SQLOutput.writeDate(java.sql.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeDate25018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeDate25018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTime25019;
		 void java.sql.SQLOutput.writeTime(java.sql.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeTime25019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeTime25019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTimestamp25020;
		 void java.sql.SQLOutput.writeTimestamp(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeTimestamp25020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeTimestamp25020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharacterStream25021;
		 void java.sql.SQLOutput.writeCharacterStream(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeCharacterStream25021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeCharacterStream25021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeAsciiStream25022;
		 void java.sql.SQLOutput.writeAsciiStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeAsciiStream25022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeAsciiStream25022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinaryStream25023;
		 void java.sql.SQLOutput.writeBinaryStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBinaryStream25023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBinaryStream25023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeRef25024;
		 void java.sql.SQLOutput.writeRef(java.sql.Ref arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeRef25024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeRef25024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBlob25025;
		 void java.sql.SQLOutput.writeBlob(java.sql.Blob arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBlob25025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBlob25025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeClob25026;
		 void java.sql.SQLOutput.writeClob(java.sql.Clob arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeClob25026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeClob25026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStruct25027;
		 void java.sql.SQLOutput.writeStruct(java.sql.Struct arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeStruct25027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeStruct25027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeURL25028;
		 void java.sql.SQLOutput.writeURL(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeURL25028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeURL25028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNString25029;
		 void java.sql.SQLOutput.writeNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeNString25029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeNString25029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLOutput"));
			global::java.sql.SQLOutput_._writeObject25006 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeObject", "(Ljava/sql/SQLData;)V");
			global::java.sql.SQLOutput_._writeInt25007 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeInt", "(I)V");
			global::java.sql.SQLOutput_._writeBytes25008 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBytes", "([B)V");
			global::java.sql.SQLOutput_._writeLong25009 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeLong", "(J)V");
			global::java.sql.SQLOutput_._writeByte25010 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeByte", "(B)V");
			global::java.sql.SQLOutput_._writeShort25011 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeShort", "(S)V");
			global::java.sql.SQLOutput_._writeFloat25012 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeFloat", "(F)V");
			global::java.sql.SQLOutput_._writeString25013 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::java.sql.SQLOutput_._writeDouble25014 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeDouble", "(D)V");
			global::java.sql.SQLOutput_._writeArray25015 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeArray", "(Ljava/sql/Array;)V");
			global::java.sql.SQLOutput_._writeBoolean25016 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBoolean", "(Z)V");
			global::java.sql.SQLOutput_._writeBigDecimal25017 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBigDecimal", "(Ljava/math/BigDecimal;)V");
			global::java.sql.SQLOutput_._writeDate25018 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeDate", "(Ljava/sql/Date;)V");
			global::java.sql.SQLOutput_._writeTime25019 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeTime", "(Ljava/sql/Time;)V");
			global::java.sql.SQLOutput_._writeTimestamp25020 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeTimestamp", "(Ljava/sql/Timestamp;)V");
			global::java.sql.SQLOutput_._writeCharacterStream25021 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeCharacterStream", "(Ljava/io/Reader;)V");
			global::java.sql.SQLOutput_._writeAsciiStream25022 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeAsciiStream", "(Ljava/io/InputStream;)V");
			global::java.sql.SQLOutput_._writeBinaryStream25023 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBinaryStream", "(Ljava/io/InputStream;)V");
			global::java.sql.SQLOutput_._writeRef25024 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeRef", "(Ljava/sql/Ref;)V");
			global::java.sql.SQLOutput_._writeBlob25025 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBlob", "(Ljava/sql/Blob;)V");
			global::java.sql.SQLOutput_._writeClob25026 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeClob", "(Ljava/sql/Clob;)V");
			global::java.sql.SQLOutput_._writeStruct25027 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeStruct", "(Ljava/sql/Struct;)V");
			global::java.sql.SQLOutput_._writeURL25028 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeURL", "(Ljava/net/URL;)V");
			global::java.sql.SQLOutput_._writeNString25029 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeNString", "(Ljava/lang/String;)V");
		}
	}
}
