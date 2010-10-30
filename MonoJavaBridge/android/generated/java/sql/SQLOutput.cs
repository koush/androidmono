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
		internal SQLOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeObject25007;
		void java.sql.SQLOutput.writeObject(java.sql.SQLData arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeObject", "(Ljava/sql/SQLData;)V", ref global::java.sql.SQLOutput_._writeObject25007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt25008;
		void java.sql.SQLOutput.writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeInt", "(I)V", ref global::java.sql.SQLOutput_._writeInt25008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes25009;
		void java.sql.SQLOutput.writeBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBytes", "([B)V", ref global::java.sql.SQLOutput_._writeBytes25009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong25010;
		void java.sql.SQLOutput.writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeLong", "(J)V", ref global::java.sql.SQLOutput_._writeLong25010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte25011;
		void java.sql.SQLOutput.writeByte(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeByte", "(B)V", ref global::java.sql.SQLOutput_._writeByte25011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort25012;
		void java.sql.SQLOutput.writeShort(short arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeShort", "(S)V", ref global::java.sql.SQLOutput_._writeShort25012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat25013;
		void java.sql.SQLOutput.writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeFloat", "(F)V", ref global::java.sql.SQLOutput_._writeFloat25013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString25014;
		void java.sql.SQLOutput.writeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeString", "(Ljava/lang/String;)V", ref global::java.sql.SQLOutput_._writeString25014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble25015;
		void java.sql.SQLOutput.writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeDouble", "(D)V", ref global::java.sql.SQLOutput_._writeDouble25015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray25016;
		void java.sql.SQLOutput.writeArray(java.sql.Array arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeArray", "(Ljava/sql/Array;)V", ref global::java.sql.SQLOutput_._writeArray25016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean25017;
		void java.sql.SQLOutput.writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBoolean", "(Z)V", ref global::java.sql.SQLOutput_._writeBoolean25017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBigDecimal25018;
		void java.sql.SQLOutput.writeBigDecimal(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBigDecimal", "(Ljava/math/BigDecimal;)V", ref global::java.sql.SQLOutput_._writeBigDecimal25018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDate25019;
		void java.sql.SQLOutput.writeDate(java.sql.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeDate", "(Ljava/sql/Date;)V", ref global::java.sql.SQLOutput_._writeDate25019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTime25020;
		void java.sql.SQLOutput.writeTime(java.sql.Time arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeTime", "(Ljava/sql/Time;)V", ref global::java.sql.SQLOutput_._writeTime25020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTimestamp25021;
		void java.sql.SQLOutput.writeTimestamp(java.sql.Timestamp arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeTimestamp", "(Ljava/sql/Timestamp;)V", ref global::java.sql.SQLOutput_._writeTimestamp25021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharacterStream25022;
		void java.sql.SQLOutput.writeCharacterStream(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeCharacterStream", "(Ljava/io/Reader;)V", ref global::java.sql.SQLOutput_._writeCharacterStream25022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeAsciiStream25023;
		void java.sql.SQLOutput.writeAsciiStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeAsciiStream", "(Ljava/io/InputStream;)V", ref global::java.sql.SQLOutput_._writeAsciiStream25023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinaryStream25024;
		void java.sql.SQLOutput.writeBinaryStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBinaryStream", "(Ljava/io/InputStream;)V", ref global::java.sql.SQLOutput_._writeBinaryStream25024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeRef25025;
		void java.sql.SQLOutput.writeRef(java.sql.Ref arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeRef", "(Ljava/sql/Ref;)V", ref global::java.sql.SQLOutput_._writeRef25025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBlob25026;
		void java.sql.SQLOutput.writeBlob(java.sql.Blob arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBlob", "(Ljava/sql/Blob;)V", ref global::java.sql.SQLOutput_._writeBlob25026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeClob25027;
		void java.sql.SQLOutput.writeClob(java.sql.Clob arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeClob", "(Ljava/sql/Clob;)V", ref global::java.sql.SQLOutput_._writeClob25027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStruct25028;
		void java.sql.SQLOutput.writeStruct(java.sql.Struct arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeStruct", "(Ljava/sql/Struct;)V", ref global::java.sql.SQLOutput_._writeStruct25028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeURL25029;
		void java.sql.SQLOutput.writeURL(java.net.URL arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeURL", "(Ljava/net/URL;)V", ref global::java.sql.SQLOutput_._writeURL25029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNString25030;
		void java.sql.SQLOutput.writeNString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeNString", "(Ljava/lang/String;)V", ref global::java.sql.SQLOutput_._writeNString25030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SQLOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLOutput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
